using System.Collections.Generic;
using Fritz.StreamLib.Core;
using Fritz.StreamTools.Hubs;
using Microsoft.AspNetCore.SignalR;

namespace Fritz.StreamTools.Services
{
  public class GitHubClient
	{

		public GitHubClient(IHubContext<GithubyMcGithubFace> mcGitHubContext)
		{

			this.McGitHubContext = mcGitHubContext;

		}

		private IHubContext<GithubyMcGithubFace> McGitHubContext { get; }

		internal void UpdateGitHub(IEnumerable<GitHubInformation> contributors)
		{
			McGitHubContext.Clients.Group("github").SendAsync("OnGitHubUpdated", contributors);
		}

	}

}