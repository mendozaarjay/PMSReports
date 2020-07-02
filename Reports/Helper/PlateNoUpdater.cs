namespace Reports
{
    public static class PlateNoUpdater
    {
        public static string Update(ref bool isSuccess, string Id, string PlateNo)
        {
            var frm = new EnterPlateNo();
            frm.PlateNo = PlateNo;
            frm.TransitId = Id;
            frm.ShowDialog();
            isSuccess = frm.IsSuccess;
            return frm.PlateNo;
        }
    }
}
