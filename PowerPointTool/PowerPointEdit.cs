using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Presentation;
using DocumentFormat.OpenXml.Drawing;
using D = DocumentFormat.OpenXml.Drawing;
using P = DocumentFormat.OpenXml.Presentation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace PowerPointTool
{
	public class PowerPointEdit
	{
		private PresentationDocument document;
		private PresentationPart presentationPart;
		private Presentation presentation;
		private SlideIdList slideIdList;
		public void OpenFile(String path, String newPath)
		{
			File.Copy(path, newPath, true);
			document = PresentationDocument.Open(newPath, true);
			presentationPart = document.PresentationPart;
			presentation = presentationPart.Presentation;
			slideIdList = presentation.SlideIdList;
		}
		public void CopyPage(int index)
		{
			SlideId slideId = slideIdList.ChildElements.OfType<SlideId>().ElementAt<SlideId>(index);
			SlidePart slidePart = (SlidePart)presentationPart.GetPartById(slideId.RelationshipId);
			Slide slide = slidePart.Slide;
			Slide newSlide = (Slide)slide.Clone();
			SlidePart newSlidePart = presentationPart.AddNewPart<SlidePart>();
			SlideId newSlideId = new SlideId();
			uint id = slideIdList.ChildElements.Cast<SlideId>().Max(x => x.Id.Value) + 1;
			slide.Save(newSlidePart);
			newSlidePart.AddPart(slidePart.SlideLayoutPart);
			slideIdList.Append(newSlideId);
			newSlideId.Id = id;
			newSlideId.RelationshipId = presentationPart.GetIdOfPart(newSlidePart);
			CopyImagePart(slidePart, newSlidePart);
		}
		public void SetText(String tag, String text, int index = -1)
		{
			SlideId slideId;
			if (index == -1)
				slideId = slideIdList.ChildElements.OfType<SlideId>().ElementAt<SlideId>(slideIdList.ChildElements.OfType<SlideId>().Count() - 1);
			else
				slideId = slideIdList.ChildElements.OfType<SlideId>().ElementAt<SlideId>(index);
			SlidePart slidePart = (SlidePart)presentationPart.GetPartById(slideId.RelationshipId);
			Slide slide = slidePart.Slide;
			int countI = 0;
			foreach (Paragraph paragraph in slide.Descendants<D.Paragraph>())
			{
				countI++;
				foreach (var pagTag in paragraph.Descendants<D.Text>())
				{
					if(pagTag.Text == tag)
						pagTag.Text = text;
				}
			}
		}
		public void SetPhoto(String tag, String imagePath, int index = -1)
		{
			SlideId slideId;
			if (index == -1)
				slideId = slideIdList.ChildElements.OfType<SlideId>().ElementAt<SlideId>(slideIdList.ChildElements.OfType<SlideId>().Count() - 1);
			else
				slideId = slideIdList.ChildElements.OfType<SlideId>().ElementAt<SlideId>(index);
			SlidePart slidePart = (SlidePart)presentationPart.GetPartById(slideId.RelationshipId);
			Slide slide = slidePart.Slide;
			var pictures = slide.Descendants<ShapeTree>().First().Descendants<P.Picture>().ToList();
			foreach (var picture in pictures)
			{
				var nonVisualPictureProperties = picture.Descendants<P.NonVisualPictureProperties>().FirstOrDefault();
				if (nonVisualPictureProperties == null)
					continue;
				var nonVisualDrawingProperties99 = nonVisualPictureProperties.Descendants<P.NonVisualDrawingProperties>().FirstOrDefault();
				if (nonVisualDrawingProperties99 == null)
					continue;
				var desc = nonVisualDrawingProperties99.Description;
				if (desc == null || desc.Value == null || !(desc.Value == tag))
					continue;

				P.BlipFill blipFill = picture.Descendants<P.BlipFill>().First();
				var blip = blipFill.Descendants<D.Blip>().First();
				string embedId = blip.Embed;
				ImagePart imagePart = (ImagePart)slidePart.GetPartById(embedId);
				if (imagePart != null)
				{
					D.Transform2D transform = picture.Descendants<D.Transform2D>().First();
					using (FileStream fileStream = new FileStream(imagePath, FileMode.Open))
					{
						imagePart.FeedData(fileStream);
						fileStream.Close();
					}
					return;
				}
			}
		}
		public void RemovePage(int index)
		{
			SlideId slideId = slideIdList.ChildElements.OfType<SlideId>().ElementAt<SlideId>(index);
			presentationPart.DeletePart(presentationPart.GetPartById(slideId.RelationshipId));
			slideIdList.RemoveChild<SlideId>(slideId);
		}
		private void CopyImagePart(SlidePart slidePart, SlidePart copySlidePart)
		{

			List<P.Picture> pictures = slidePart.Slide.Descendants<ShapeTree>().First().Descendants<P.Picture>().ToList();
			foreach (var picture in pictures)
			{
				var nonVisualPictureProperties = picture.Descendants<P.NonVisualPictureProperties>().FirstOrDefault();
				if (nonVisualPictureProperties == null)
					continue;
				var nonVisualDrawingProperties99 = nonVisualPictureProperties.Descendants<P.NonVisualDrawingProperties>().FirstOrDefault();
				if (nonVisualDrawingProperties99 == null)
					continue;
				var desc = nonVisualDrawingProperties99.Description;
				if (desc == null || desc.Value == null)
					continue;

				P.BlipFill blipFill = picture.Descendants<P.BlipFill>().First();
				var blip = blipFill.Descendants<D.Blip>().First();
				string embedId = blip.Embed;
				copySlidePart.AddImagePart(ImagePartType.Png, embedId);
			}
		}
		public void CloseFile()
		{
			slideIdList = null;
			presentation = null;
			presentationPart = null;
			document.Dispose();
			GC.Collect();
		}
	}
}
