
namespace ManagementBlock.Infrastructure.SharedKennel
{
    public abstract class DomainEntity<T>
    {
        public T Id { get; set; }
        /// <summary>
        /// True if domain entity has an identity
        /// </summary>
        /// <returns></returns>
        public bool IsTrasient()
        {
            return Id.Equals(default(T));
        }

    }
}
