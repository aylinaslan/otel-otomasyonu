// Room rate range
public double cheapest { get; set; }
public double expensive { get; set; }
// Ensure TempData is stored for the next call.
TempData["page"] = page;
TempData["searchfor"] = model.searchText;

// Calculate the room rate ranges.
await foreach (var result in model.resultList.GetResultsAsync())
{
    var cheapest = 0d;
    var expensive = 0d;

    foreach (var room in result.Document.Rooms)
    {
        var rate = room.BaseRate;
        if (rate < cheapest || cheapest == 0)
        {
            cheapest = (double)rate;
        }
        if (rate > expensive)
        {
            expensive = (double)rate;
        }
    }
    model.resultList.Results[n].Document.cheapest = cheapest;
    model.resultList.Results[n].Document.expensive = expensive;
}