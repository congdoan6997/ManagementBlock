namespace ManagementBlock.Data.Interfaces
{
    interface IHasSoftDelete
    {
        bool IsDeleted { get; set; }
    }
}
