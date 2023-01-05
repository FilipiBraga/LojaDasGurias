using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDasGurias.Tests.Mapper
{
    public class Fixture
    {
        public IMapper Mapper { get; }

        public Fixture()
        {
            Mapper = new MapperConfiguration(op => 
            {
                //op.AddProfile(new LojaDasGurias.Application.Mappings.Class1());
            })
            .CreateMapper();
        }
    }
}
