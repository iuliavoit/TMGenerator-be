namespace TMGbe.Models;

public class ColumnBase
{
    
}
public class Column<T,R> : ColumnBase
{
    public string? id;
    public string? name;
    public string? nameStyle;
    public string? description;
    public string? descriptionStyle;
    public Boolean? sortable;
    public Boolean? borderL;
    public Boolean? borderR;
    public Boolean? borderB;
    public List<ColumnBase>? childrenColumns;
        
    public Func<T, R>? computer;
    public Func<T, R, Dictionary<string, string>>? conditionalFormatter;
    public Func<R, string>? displayFormatter;
    
    public string type { get; }
    
    public Column(
        string? id,
        string? name,
        string? nameStyle,
        Func<T, R>? computer = null,
        Func<T, R, Dictionary<string, string>>? conditionalFormatter = null,
        string? description = "",
        string? descriptionStyle = null,
        bool? sortable = null,
        bool? borderL = null,
        bool? borderR = null,
        bool? borderB = null,
        List<ColumnBase>? childrenColumns = null
    )
    {
        this.id = id;
        this.computer = computer;
        this.name = name;
        this.nameStyle = nameStyle ?? "";
        this.conditionalFormatter = conditionalFormatter;
        this.description = description;
        this.descriptionStyle = descriptionStyle ?? "";
        this.sortable = sortable ?? true;
        this.childrenColumns = childrenColumns ?? new List<ColumnBase>();
        this.type = typeof(R).Name;
        this.borderL = borderL;
        this.borderR = borderR;
        this.borderB = borderB;
    }
}