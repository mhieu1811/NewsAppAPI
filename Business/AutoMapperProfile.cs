using AutoMapper;
using DataAccessor.Entities;
using Contracts.Dtos;
using System;

namespace Business
{
    public class AutoMapperProfile : AutoMapper.Profile
    {
        public AutoMapperProfile()
        {
            FromDataAccessorLayer();
            FromPresentationLayer();
        }

        private void FromPresentationLayer()
        {
    


        }

        private void FromDataAccessorLayer()
        {
       

        }
    }
}
