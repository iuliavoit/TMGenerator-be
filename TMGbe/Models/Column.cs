namespace TMGbe.Models;

public class ColumnBase
{
    
}
public class Column<T,R> : ColumnBase
{
    public string? id;
    public string? name;
    public string? description;
    public Boolean? sortable;
    public List<ColumnBase>? childrenColumns;
        
    public Func<T, R>? computer;
    public Func<T, R, Dictionary<string, string>>? conditionalFormatter;
    public Func<R, string>? displayFormatter;
        
    public Column(string? id, Func<T, R>? computer, string? name, Func<T, R, Dictionary<string, string>>? conditionalFormatter, List<ColumnBase>? childrenColumns = null, string? description = "", bool sortable = true)
    {
        this.id = id;
        this.computer = computer;
        this.name = name;
        this.conditionalFormatter = conditionalFormatter;
        this.description = description;
        this.sortable = sortable;
        this.childrenColumns = childrenColumns ?? new List<ColumnBase>();
    }
}