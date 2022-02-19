<!-- Show the hotel data. -->
@for (var i = 0; i < result.Count; i++)
{
    var rateText = $"Rates from ${result[i].Document.cheapest} to ${result[i].Document.expensive}";
    var lastRenovatedText = $"Last renovated: { result[i].Document.LastRenovationDate.Value.Year}";
    var ratingText = $"Rating: {result[i].Document.Rating}";

    string fullDescription = result[i].Document.Description;

    // Display the hotel details.
    @Html.TextArea($"name{i}", result[i].Document.HotelName, new { @class = "box1A" })
    @Html.TextArea($"rating{i}", ratingText, new { @class = "box1B" })
    @Html.TextArea($"rates{i}", rateText, new { @class = "box2A" })
    @Html.TextArea($"renovation{i}", lastRenovatedText, new { @class = "box2B" })
    @Html.TextArea($"desc{i}", fullDescription, new { @class = "box3" })
}