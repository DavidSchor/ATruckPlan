using FluentAssertions;
using OpenStreetMapIntegration.Services;
using Xunit;

namespace OpenStreetMapIntegration.Test
{
    public class OpenStreetMapMetaDataServiceTest
    {
        // Clearly the restclient should be mocked out here. But I am out of time.
        [Fact]
        public void GIVEN_LatAndLongForDFDS_WHEN_GetCountry_THEN_DenmarkIsReturned()
        {
            var sut = new OpenStreetMapMetadataService();

            var result = sut.GetCountry(12.596248647040307, 55.701918702183555);
            result.Should().Be("Danmark");
        }
    }
}