namespace RepuestoM.Shared.Wrapper
{
    internal class ResultList<T>
    {
        public ResultList()
        {
        }

        public bool Succeeded { get; set; }
        public List<string> Message { get; set; }
        public IEnumerable<T> Items { get; set; }
    }
}