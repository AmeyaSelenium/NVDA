// Copyright (C) 2019 Juan José Montiel
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.

namespace NvdaTestingDriver.Settings
{
	/// <summary>
	/// Sets the progress bar update settings
	/// </summary>
	public class ProgressBarUpdateSettings
	{
		/// <summary>
		/// Gets or sets the progress bar output mode.
		/// </summary>
		/// <value>
		/// The progress bar output mode.
		/// </value>
		public ProgressBarOutputMode ProgressBarOutputMode { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether NVDA should report progress bars outside current window.
		/// </summary>
		/// <value>
		///   <c>true</c> if  NVDA should report background progress bars; otherwise, <c>false</c>.
		/// </value>
		public bool ReportBackgroundProgressBars { get; set; }
	}
}