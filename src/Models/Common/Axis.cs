﻿namespace PSC.Blazor.Components.Chartjs.Models.Common
{
    public sealed class Axis
    {
        /// <summary>
        /// Gets or sets the begin at zero.
        /// </summary>
        /// <value>
        /// The begin at zero.
        /// </value>
        [JsonPropertyName("beginAtZero")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? BeginAtZero { get; set; }

        /// <summary>
        /// Gets or sets the grid.
        /// </summary>
        /// <value>
        /// The grid.
        /// </value>
        [JsonPropertyName("grid")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Grid? Grid { get; set; }

        /// <summary>
        /// Determines the maximum of the parameters.
        /// </summary>
        /// <value>
        /// The maximum.
        /// </value>
        [JsonPropertyName("max")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public double? Max { get; set; }

        /// <summary>
        /// Determines the minimum of the parameters.
        /// </summary>
        /// <value>
        /// The minimum.
        /// </value>
        [JsonPropertyName("min")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public double? Min { get; set; }

        /// <summary>
        /// Gets or sets the position.
        /// </summary>
        /// <value>
        /// The position.
        /// </value>
        [JsonPropertyName("position")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Position { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this axis is stacked.
        /// </summary>
        /// <value>
        ///   <c>true</c> if stacked; otherwise, <c>false</c>.
        /// </value>
        [JsonPropertyName("stacked")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Stacked { get; set; }

        /// <summary>
        /// Gets or sets the ticks.
        /// </summary>
        /// <value>
        /// The ticks.
        /// </value>
        [JsonPropertyName("ticks")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Ticks? Ticks { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        [JsonPropertyName("title")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public AxesTitle? Title { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        [JsonPropertyName("type")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Type { get; set; }
    }
}