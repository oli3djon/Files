﻿// Copyright (c) Files Community
// Licensed under the MIT License.

namespace Files.App.Actions
{
	internal sealed partial class CloseOtherTabsSelectedAction : CloseTabBaseAction
	{
		public override string Label
			=> Strings.CloseOtherTabs.GetLocalizedResource();

		public override string Description
			=> Strings.CloseOtherTabsSelectedDescription.GetLocalizedResource();

		public CloseOtherTabsSelectedAction()
		{
		}

		public override Task ExecuteAsync(object? parameter = null)
		{
			MultitaskingTabsHelpers.CloseOtherTabs(context.SelectedTabItem, context.Control!);

			return Task.CompletedTask;
		}
	}
}
