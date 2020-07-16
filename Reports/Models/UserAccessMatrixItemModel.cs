namespace Reports.Models
{
    public class UserAccessMatrixItemModel
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int RoleId { get; set; }
        public string RoleCode { get; set; }
        public string RoleDescription { get; set; }
        public int ModuleId { get; set; }
        public string ModuleCode { get; set; }
        public string ModuleDescription { get; set; }
        public int TypeId { get; set; }
        public string Type { get; set; }
        public string CanAdd { get; set; }
        public string CanEdit { get; set; }
        public string CanSave { get; set; }
        public string CanDelete { get; set; }
        public string CanSearch { get; set; }
        public string CanPrint { get; set; }
        public string CanExport { get; set; }
        public string CanAccess { get; set; }
    }
}
