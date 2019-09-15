using IdentityServer4.Models;
using IdentityServer4.Test;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using static IdentityServer4.Models.IdentityResources;

namespace IdServer
{
    internal static class IdentitySetup
    {
        public static IIdentityServerBuilder AddIdentityServerObjects(
            this IIdentityServerBuilder builder)
        {
            return builder
                .AddInMemoryClients(new List<Client>
                {
                    new Client
                    {
                        ClientId = "WebApp",
                        ClientName = "",
                        ClientSecrets = new []
                        {
                            new Secret("clientSecret".Sha256())
                        },
                        AllowedGrantTypes = new [] { "client_credentials" },
                        AllowedScopes = new [] {
                            "api"
                        }
                    }
                })
                .AddInMemoryIdentityResources(new IdentityResource[]
                {
                    new OpenId(),
                })
                .AddInMemoryApiResources(new[] {
                    new ApiResource
                    {
                        Name = "api",
                        DisplayName = "API",
                        ApiSecrets = new [] { new Secret("apiSecret".Sha256()) },
                        Scopes = new []
                        {
                            new Scope("api"),
                        }
                    }
                })
                .AddTestUsers(new List<TestUser>
                {
                    new TestUser
                    {
                        SubjectId = "09f7f68b-bf08-490b-9032-0f6f0258627a",
                        Username = "michael",
                        Password = "dev"
                    }
                })
                .AddDeveloperSigningCredential();
        }
    }
}
