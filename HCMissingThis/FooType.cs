namespace HCMissingThis
{
  public record Foo(string Id, string bar);

  public class FooType : ObjectType<Foo>
  {
    protected override void Configure(IObjectTypeDescriptor<Foo> descriptor)
    {
      descriptor.Name("Foo");
      descriptor.Field(foo => foo.Id).Type<IdType>();
      descriptor.Field(foo => foo.bar).Type<StringType>();
    }


    [DataLoader]
    public static Task<IReadOnlyDictionary<string, Foo>> GetFooById(IReadOnlyList<string> id)
    {
      return Task.FromResult<IReadOnlyDictionary<string, Foo>>(new Dictionary<string, Foo>().AsReadOnly());
    }
  }
}
