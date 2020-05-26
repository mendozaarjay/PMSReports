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
    }
}
