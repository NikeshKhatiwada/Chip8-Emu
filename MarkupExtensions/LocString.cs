﻿using Chip8_Emu.Resources.Strings;

namespace Chip8_Emu.MarkupExtensions;

[ContentProperty(nameof(Name))]
public class LocString : IMarkupExtension<string>
{
	public string? Name { get; set; }

	public string ProvideValue(IServiceProvider serviceProvider)
	{
		if (string.IsNullOrEmpty(Name))
		{
			return string.Empty;
		}

		return AppResources.ResourceManager?.GetString(Name) ?? string.Empty;
	}

	object IMarkupExtension.ProvideValue(IServiceProvider serviceProvider)
	{
		return ProvideValue(serviceProvider);
	}
}
