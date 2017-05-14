namespace SBS.Data.Entities
{
    public class PedalDeploymentJack
    {
        public virtual int PedalDeploymentJackID { get; set; }
        public virtual PedalDeployment PedalDeployment { get; set; }
        public virtual PedalJack Jack { get; set; }
        public virtual PedalDeploymentJack ConnectedJack { get; set; }
        public virtual bool IsInput { get; set; }
        public virtual bool IsOutput { get; set; }
    }
}
