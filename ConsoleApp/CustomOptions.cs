﻿namespace ConsoleApp;


public sealed class CustomOptions
{
	public const string Section = "CustomSettings";


	public string? Url { get; set; }


	public bool UseHttps { get; set; }
}
