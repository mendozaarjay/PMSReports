namespace Reports
{
    public static class ImageViewer
    {
        public static void ShowImage(int id)
        {
            ImageViewerForm frm = new ImageViewerForm();
            frm.TransitId = id;
            frm.ShowDialog();
        }
        //public static void ShowImage(int id,bool useHighResolution)
        //{
        //    ImageViewerForm frm = new ImageViewerForm();
        //    frm.TransitId = id;
        //    frm.UseHighResolutionImages = useHighResolution;
        //    frm.ShowDialog();
        //}
    }
}
