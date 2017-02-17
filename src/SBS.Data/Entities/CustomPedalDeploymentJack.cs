namespace SBS.Data.Entities
{
    public class CustomPedalDeploymentJack : VersionedEntity
    {
        public virtual int CustomPedalDeploymentJackID { get; set; }
        public virtual CustomPedalDeployment CustomPedalDeployment { get; set; }
        public virtual PedalJackType Type { get; set; }
        public virtual string Name { get; set; }
    }
}
