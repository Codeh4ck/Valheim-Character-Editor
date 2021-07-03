namespace ValheimCharacterEditor.Models
{
    public abstract class BaseDifference<T>
    {
        public T PreviousValue { get; set; }
        public T NewValue { get; set; }
    }
}
