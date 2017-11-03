using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Entities
{
    public static class CityInfoExtensions
    {
        public static void EnsureSeedDataForContext(this CityInfoContext context)
        {
            if (context.Cities.Any())
            {
                return;
            }

            var cities = new List<City>()
            {
                new City()
                {
                    Name = "New York City",
                    Description = "The one with that big park.",
                    PointsOfInterest = new List<PointOfInterest>()
                    {
                        new PointOfInterest() {
                            Name = "Central Park",
                            Description = "The most visited urban park in the United States." },
                        new PointOfInterest() {
                            Name = "Empire State Building",
                            Description = "A 102-story skyscraper located in Midtown Manhattan." }
                    }
                },
                new City()
                {
                    Name = "Antwerp",
                    Description = "The one with the cathedral that was never really finished.",
                    PointsOfInterest = new List<PointOfInterest>()
                    {
                        new PointOfInterest() {
                            Name = "Antwerp - Central Park",
                            Description = "The most visited urban park in the United States." },
                        new PointOfInterest() {
                            Name = "Antwerp - Empire State Building",
                            Description = "A 102-story skyscraper located in Midtown Manhattan." }
                    }
                },
                new City()
                {
                    Name = "Paris",
                    Description = "The one with that big tower.",
                    PointsOfInterest = new List<PointOfInterest>()
                    {
                        new PointOfInterest() {
                            Name = "PARIS - Central Park",
                            Description = "The most visited urban park in the United States." },
                        new PointOfInterest() {
                            Name = "PARIS - Empire State Building",
                            Description = "A 102-story skyscraper located in Midtown Manhattan." }
                    }
                }
            };

            context.Cities.AddRange(cities);
            context.SaveChanges();
        }
    }
}
