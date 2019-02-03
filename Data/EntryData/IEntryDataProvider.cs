namespace Data.EntryData
{
    interface IEntryDataProvider<TEntity> where TEntity : class
    {
        TEntity[] Data { get; }
    }
}
