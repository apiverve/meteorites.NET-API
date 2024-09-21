using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class geolocation
{
    [JsonProperty("type")]
    public string type { get; set; }

    [JsonProperty("coordinates")]
    public double[] coordinates { get; set; }

}

public class meteors
{
    [JsonProperty("name")]
    public string name { get; set; }

    [JsonProperty("recclass")]
    public string recclass { get; set; }

    [JsonProperty("mass")]
    public string mass { get; set; }

    [JsonProperty("year")]
    public string year { get; set; }

    [JsonProperty("geolocation")]
    public geolocation geolocation { get; set; }

}

public class data
{
    [JsonProperty("count")]
    public int count { get; set; }

    [JsonProperty("filteredOn")]
    public string[] filteredOn { get; set; }

    [JsonProperty("meteors")]
    public meteors[] meteors { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
