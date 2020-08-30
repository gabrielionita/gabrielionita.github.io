using BlazorApp.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Net.Http;

namespace BlazorApp.Pages
{
	public partial class Contact : ComponentBase
	{
		private ContactModel contact;

		[Inject]
		private NavigationManager Navigation { get; set; }

		[Inject]
		private HttpClient HttpClient { get; set; }

		protected override void OnInitialized()
		{
			OnReset();
		}

		private void OnReset()
		{
			contact = new ContactModel();
		}

		private void OnValidSubmit()
		{
			Console.WriteLine(HttpClient.BaseAddress.AbsoluteUri);
			Navigation.NavigateTo("/");
		}
	}
}
