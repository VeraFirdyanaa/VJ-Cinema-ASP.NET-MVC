﻿ using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VJCinema.Dtos;
using VJCinema.Models;

namespace VJCinema.App_Start
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			//Domain to Dto
			Mapper.CreateMap<Customer, CustomerDto>();
			Mapper.CreateMap<Movie, MovieDto>();
			Mapper.CreateMap<MembershipType, MembershipTypeDto>();

			//Dto to Domain
			Mapper.CreateMap<CustomerDto, Customer>()
				.ForMember(m => m.idCustomer, opt => opt.Ignore());

			Mapper.CreateMap<MovieDto, Movie>()
				.ForMember(m => m.idMovie, opt => opt.Ignore());
		}
	}
}