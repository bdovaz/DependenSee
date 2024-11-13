namespace DependenSee;

public class DiscoveryResult
{
    public List<Project> Projects { get; } = [];
    public List<Package> Packages { get; } = [];
    public List<Reference> References { get; } = [];
}

public class Project(string id, string name)
{
    public string Id { get; } = id;
    public string Name { get; } = name;
}

public class Package(string id, string name)
{
    public string Id { get; } = id;
    public string Name { get; } = name;
}

public class Reference(string from, string to)
{
    public string From { get; } = from;
    public string To { get; } = to;
}
