namespace mytunes.Core.Entities
{
    public abstract class BaseEntity
    {
        public virtual int Id { get; set; }
        
        public virtual bool isAble { get; set; }
    }
}