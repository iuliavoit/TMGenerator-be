using TMGbe.Models;

public class Knowledge
{
    public List<ColumnBase> getKnowledgeTableData()
    {
        Column<Component, String> nameColumn =
            new Column<Component, string>("component", null, "Component", null);
        Column<Component, String> nameColumnWrapper =
            new Column<Component, string>(null, null, "", null, new List<ColumnBase>() { nameColumn });
        Column<Component, long> filesColumn =
            new Column<Component, long>("#files", null, "#", null);
        Column<Component, long> filesColumnWrapper =
            new Column<Component, long>("files", null, "files", null, new List<ColumnBase>() { filesColumn });
        Column<Component, int> linesColumn = new Column<Component, int>("x1000", null, "x1000", null);
        Column<Component, int> linesColumnWrapper =
            new Column<Component, int>("lines", null, "lines", null, new List<ColumnBase>() { linesColumn });
        Column<Component, int> commitsColumn = new Column<Component, int>("#commits", null, "#", null);
        Column<Component, int> commitsColumnWrapper = new Column<Component, int>("commits", null, "commits", null,
            new List<ColumnBase>() { commitsColumn });
        Column<Component, int> startDateColumn = new Column<Component, int>("yyyy-mmstart", null, "yyyy-mm", null);
        Column<Component, int> startDateColumnWrapper = new Column<Component, int>("startDate", null, "start date",
            null, new List<ColumnBase>() { startDateColumn });
        Column<Component, int> latestDateColumn = new Column<Component, int>("yyyy-mmlatest", null, "yyyy-mm", null);
        Column<Component, int> latestDateColumnWrapper = new Column<Component, int>("latestDate", null, "latest date",
            null, new List<ColumnBase>() { latestDateColumn });
        Column<Component, int> firstHeaderColumn = new Column<Component, int>(null, null, "", null,
            new List<ColumnBase>()
            {
                nameColumnWrapper, filesColumnWrapper, linesColumnWrapper, commitsColumnWrapper, startDateColumnWrapper,
                latestDateColumnWrapper
            });
        
        Column<Component, int> devsColumn = new Column<Component, int>("#devs", null, "#", null);
        Column<Component, int> devsColumnWrapper = new Column<Component, int>("alldevs", null,
            "all" + "<br>" + "devs", null, new List<ColumnBase>() { devsColumn });
        Column<Component, long> activeDevsColumnOne =
            new Column<Component, long>("#activedevs", null, "#", null);
        Column<Component, long> activeDevsColumnTwo =
            new Column<Component, long>("%allactivedevs", null, "%all", null);
        Column<Component, long> activeDevsColumnWrapper =
            new Column<Component, long>("activeDevs", null, "active"+"<br>"+"recently", null, new List<ColumnBase>() { activeDevsColumnOne, activeDevsColumnTwo });
        Column<Component, long> joinedDevsColumnOne =
            new Column<Component, long>("#joineddevs", null, "#", null);
        Column<Component, long> joinedDevsColumnTwo =
            new Column<Component, long>("%alljoineddevs", null, "%all", null);
        Column<Component, long> joinedDevsColumnWrapper =
            new Column<Component, long>("joinedDevs", null, "joined"+"<br>"+"recently", null, new List<ColumnBase>() { joinedDevsColumnOne, joinedDevsColumnTwo });
        Column<Component, int> secondHeaderColumn = new Column<Component, int>(null, null, "Developers", null,
            new List<ColumnBase>()
            {
                devsColumnWrapper, activeDevsColumnWrapper,joinedDevsColumnWrapper
            });

        Column<Component, int> knowledgeActiveColumn = new Column<Component, int>("%activeknowledge", null, "%", null);
        Column<Component, int> knowledgeActiveColumnWrapper =
            new Column<Component, int>("activeknowledge", null, "on" + "<br>" + "$recentDate", null,
                new List<ColumnBase>() { knowledgeActiveColumn });
        Column<Component, int> nowActiveKnowledgeColumnOne =
            new Column<Component, int>("%nowactiveknowledge", null, "%", null);
        Column<Component, int> nowActiveKnowledgeColumnTwo =
            new Column<Component, int>("trendnowactiveknowledge", null, "%", null);
        Column<Component, int> nowActiveKnowledgeColumnWrapper = new Column<Component, int>("nowactiveknowledge", null,
            "now", null, new List<ColumnBase>() { nowActiveKnowledgeColumnOne, nowActiveKnowledgeColumnTwo });
        Column<Component, int> thirdHeaderColumn = new Column<Component, int>(null, null, "Active Project"+"<br>"+"Knowledge", null,
            new List<ColumnBase>()
            {
                knowledgeActiveColumnWrapper, nowActiveKnowledgeColumnWrapper
            }/*, description:"based on volume of change"+"<br>"+"from current developers "*/);
        
        Column<Component, long> filesWeakColumn =
            new Column<Component, long>("#filesweak", null, "#", null);
        Column<Component, long> filesWeakColumnWrapper =
            new Column<Component, long>("filesweak", null, "files", null, new List<ColumnBase>() { filesWeakColumn });
        Column<Component, long> activeWeakColumnOne =
            new Column<Component, long>("#activeweak", null, "#", null);
        Column<Component, long> activeWeakColumnTwo =
            new Column<Component, long>("activeweaktrend", null, "trend", null);
        Column<Component, long> activeWeakColumnWrapper =
            new Column<Component, long>("activeWeak", null, "active"+"<br>"+"recently", null, new List<ColumnBase>() { activeWeakColumnOne, activeWeakColumnTwo });
        Column<Component, int> fourthHeaderColumn = new Column<Component, int>(null, null, "Weak"+"<br>"+"Ownership", null,
            new List<ColumnBase>()
            {
                filesWeakColumnWrapper, activeWeakColumnWrapper
            }/*, description:"files where current developers"+"<br>"+"have small volume of change "*/);
        
        Column<Component, long> filesPolarisedColumn =
            new Column<Component, long>("#filespolarised", null, "#", null);
        Column<Component, long> filesPolarisedColumnWrapper =
            new Column<Component, long>("filespolarised", null, "files", null, new List<ColumnBase>() { filesPolarisedColumn });
        Column<Component, long> activePolarisedColumnOne =
            new Column<Component, long>("#activepolarised", null, "#", null);
        Column<Component, long> activePolarisedColumnTwo =
            new Column<Component, long>("activepolarisedtrend", null, "trend", null);
        Column<Component, long> activePolarisedColumnWrapper =
            new Column<Component, long>("activePolarised", null, "active"+"<br>"+"recently", null, new List<ColumnBase>() { activePolarisedColumnOne, activePolarisedColumnTwo });
        Column<Component, int> fifthHeaderColumn = new Column<Component, int>(null, null, "Polarised"+"<br>"+"Ownership", null,
            new List<ColumnBase>()
            {
                filesPolarisedColumnWrapper, activePolarisedColumnWrapper
            }/*, description:"files with a very few developers"+"<br>"+"doing significant work"*/);
        
        return new List<ColumnBase>() { firstHeaderColumn, secondHeaderColumn, thirdHeaderColumn, fourthHeaderColumn, fifthHeaderColumn };
    }
}