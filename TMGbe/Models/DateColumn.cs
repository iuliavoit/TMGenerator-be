
namespace TMGbe.Models
{
    public class DateColumn<T> : Column<T, DateTime>
    {
        public string DateFormat { get; }

        public DateColumn(
            string? id,
            string? name,
            string? nameStyle,
            string dateFormat,
            Func<T, DateTime>? computer = null,
            Func<T, DateTime, Dictionary<string, string>>? conditionalFormatter = null,
            string? description = "",
            string? descriptionStyle = null,
            bool? sortable = null,
            bool? borderL = null,
            bool? borderR = null,
            bool? borderB = null,
            List<ColumnBase>? childrenColumns = null
        ) : base(
            id,
            name,
            nameStyle,
            computer,
            conditionalFormatter,
            description,
            descriptionStyle,
            sortable,
            borderL,
            borderR,
            borderB,
            childrenColumns
        )
        {
            DateFormat = dateFormat;
            displayFormatter = value => value.ToString(DateFormat);
        }
    }
}