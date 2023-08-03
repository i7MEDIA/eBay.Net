using EbayNet;
using EbayNet.Authentication;
using EbayNet.BrowseAPIs;
using Flurl.Http.Testing;
using NSubstitute;
using System.Threading.Tasks;
using Xunit;

namespace ebay.tests
{
	public sealed class ItemTests
	{
		[Fact]
		public async Task GetItem_ShouldResolve_UrlCorrectly()
		{

			var moqAuth = Substitute.For<IOAuth2Authenticator>();
			moqAuth.GetTokenAsync().Returns(new Token
			{
				AccessToken = "randomtoken"
			});

			var restClient = new EbayRestClient
			{
				Authenticator = moqAuth
			};

			var item = new Item(restClient);

			using (var httpTest = new HttpTest())
			{
				var itemModel = await item.GetAsync("123");
				httpTest
					.ShouldHaveCalled("https://api.ebay.com/buy/browse/v1/item/v1%7C123%7C0")
					.WithContentType("application/json")
					.WithHeader("Authorization", "Bearer randomtoken")
					.WithHeader("X-EBAY-C-ENDUSERCTX", "*")
					.Times(1);
			}
		}

		[Fact]
		public async Task GetItem_ShouldResolve_UrlCorrectly_Sandbox()
		{

			var moqAuth = Substitute.For<IOAuth2Authenticator>();
			moqAuth.GetTokenAsync().Returns(new Token
			{
				AccessToken = "randomtoken"
			});

			var restClient = new EbayRestClient
			{
				Authenticator = moqAuth,
				UrlService = new UrlService(EbayNet.Environment.Sandbox)
			};

			var item = new Item(restClient);

			using (var httpTest = new HttpTest())
			{
				var itemModel = await item.GetAsync("123");
				httpTest
					.ShouldHaveCalled("https://api.sandbox.ebay.com/buy/browse/v1/item/v1%7C123%7C0")
					.WithContentType("application/json")
					.WithHeader("Authorization", "Bearer randomtoken")
					.WithHeader("X-EBAY-C-ENDUSERCTX", "*")
					.Times(1);
			}
		}

		[Fact]
		public async Task GetLegacyItem_ShouldResolve_UrlCorrectly()
		{

			var moqAuth = Substitute.For<IOAuth2Authenticator>();
			moqAuth.GetTokenAsync().Returns(new Token
			{
				AccessToken = "randomtoken"
			});

			var restClient = new EbayRestClient
			{
				Authenticator = moqAuth
			};

			var item = new Item(restClient);

			using (var httpTest = new HttpTest())
			{
				var itemModel = await item.GetByLegacyIdAsync("123");
				httpTest
					.ShouldHaveCalled("https://api.ebay.com/buy/browse/v1/item/get_item_by_legacy_id/%3Flegacy_item_id%3D123")
					.WithContentType("application/json")
					.WithHeader("Authorization", "Bearer randomtoken")
					.WithHeader("X-EBAY-C-ENDUSERCTX", "*")
					.Times(1);
			}
		}

		[Fact]
		public async Task GetLegacyItem_ShouldResolve_UrlCorrectly_Sandbox()
		{

			var moqAuth = Substitute.For<IOAuth2Authenticator>();
			moqAuth.GetTokenAsync().Returns(new Token
			{
				AccessToken = "randomtoken"
			});

			var restClient = new EbayRestClient
			{
				Authenticator = moqAuth,
				UrlService = new UrlService(EbayNet.Environment.Sandbox)
			};

			var item = new Item(restClient);

			using (var httpTest = new HttpTest())
			{
				var itemModel = await item.GetByLegacyIdAsync("123");
				httpTest
					.ShouldHaveCalled("https://api.sandbox.ebay.com/buy/browse/v1/item/get_item_by_legacy_id/%3Flegacy_item_id%3D123")
					.WithContentType("application/json")
					.WithHeader("Authorization", "Bearer randomtoken")
					.WithHeader("X-EBAY-C-ENDUSERCTX", "*")
					.Times(1);
			}
		}

		[Fact]
		public async Task GetItemsByItemGroup_ShouldResolve_UrlCorrectly()
		{

			var moqAuth = Substitute.For<IOAuth2Authenticator>();
			moqAuth.GetTokenAsync().Returns(new Token
			{
				AccessToken = "randomtoken"
			});

			var restClient = new EbayRestClient
			{
				Authenticator = moqAuth
			};

			var item = new Item(restClient);

			using (var httpTest = new HttpTest())
			{
				var itemModel = await item.GetByItemGroupAsync("123");
				httpTest
					.ShouldHaveCalled("https://api.ebay.com/buy/browse/v1/item/get_items_by_item_group/%3Fitem_group_id%3D123")
					.WithContentType("application/json")
					.WithHeader("Authorization", "Bearer randomtoken")
					.WithHeader("X-EBAY-C-ENDUSERCTX", "*")
					.Times(1);
			}
		}

		[Fact]
		public async Task GetItemsByItemGroup_ShouldResolve_UrlCorrectly_Sandbox()
		{

			var moqAuth = Substitute.For<IOAuth2Authenticator>();
			moqAuth.GetTokenAsync().Returns(new Token
			{
				AccessToken = "randomtoken"
			});

			var restClient = new EbayRestClient
			{
				Authenticator = moqAuth,
				UrlService = new UrlService(EbayNet.Environment.Sandbox)
			};

			var item = new Item(restClient);

			using (var httpTest = new HttpTest())
			{
				var itemModel = await item.GetByItemGroupAsync("123");
				httpTest
					.ShouldHaveCalled("https://api.sandbox.ebay.com/buy/browse/v1/item/get_items_by_item_group/%3Fitem_group_id%3D123")
					.WithContentType("application/json")
					.WithHeader("Authorization", "Bearer randomtoken")
					.WithHeader("X-EBAY-C-ENDUSERCTX", "*")
					.Times(1);
			}
		}
	}
}


