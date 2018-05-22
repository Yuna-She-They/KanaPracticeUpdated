/*
using System;
using System.Collections.Generic;
using System.Linq;
using LinqToSql.Futures;
using Xunit;

namespace LinqToSql.Futures.Examples
{
    public partial class SimpleDataContext : IFutureDataContext
    {
        protected override void Dispose(bool disposing)
        {
            if (_futureCollection != null)
            {
                _futureCollection.Dispose();
                _futureCollection = null;
            }
    
            base.Dispose(disposing);
        }
    
        private IFutureCollection _futureCollection;
        public IFutureCollection FutureCollection
        {
            get
            {
                if (_futureCollection == null)
                    _futureCollection = this.CreateFutureCollection();
    
                return _futureCollection;
            }
        }
    }

    public class FutureTests
    {
        [Fact]
        public void ToFuture()
        {
            // SimpleDataContext Implements IFutureDataContext 
            using (var dataContext = new SimpleDataContext())
            {
                Lazy<IList<Person>> people = dataContext.Persons
                    .Where(p => p.FirstName == "Tom" || p.FirstName == "Cat")
                    .ToFuture();
        
                Lazy<IList<Pet>> pets = dataContext.Pets
                    .Where(p => p.Name == "Taboo")
                    .ToFuture();
        
                // Single database call!
                Assert.Equal(2, people.Value.Count);
                Assert.Equal(1, pets.Value.Count);
            }
        }
        
        [Fact]
        public void FutureCollection()
        {
            using (var dataContext = new SimpleDataContext())
            using (var futureCollcetion = dataContext.CreateFutureCollection())
            {
                Lazy<IList<Person>> people = dataContext.Persons
                    .Where(p => p.FirstName == "Tom" || p.FirstName == "Cat")
                    .ToFuture(futureCollcetion);
        
                Lazy<IList<Pet>> pets = dataContext.Pets
                    .Where(p => p.Name == "Taboo")
                    .ToFuture(futureCollcetion);
        
                // Single database call!
                Assert.Equal(2, people.Value.Count);
                Assert.Equal(1, pets.Value.Count);
            }
        }
    }
}
*/