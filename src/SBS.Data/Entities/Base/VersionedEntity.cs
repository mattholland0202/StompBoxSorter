namespace SBS.Data.Entities
{
    public abstract class VersionedEntity : IVersionedEntity
    {
        public virtual byte[] Version { get; set; }
    }
}
