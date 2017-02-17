namespace SBS.Data.Entities
{
    public class PedalDeploymentJack
    {
        public virtual int PedalDeploymentJackID { get; set; }
        public virtual PedalDeployment PedalDeployment { get; set; }
        public virtual PedalJack Jack { get; set; }

        // Links - only one will be populated
        public virtual PedalDeploymentJack PedalDeploymentConnection { get; set; }
        public virtual CustomPedalDeploymentJack CustomPedalDeploymentConnection { get; set; }
    }
}
