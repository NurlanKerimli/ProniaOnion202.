using AutoMapper;
using ProniaOnion202.Application.DTOs.Color;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProniaOnion202.Application.MappingProfiles
{
	public class ColorProfile:Profile
	{
        public ColorProfile()
        {
            CreateMap<Color, ColorItemDto>().ReverseMap();
            CreateMap<Color, IncludeColorDto>().ReverseMap();
            CreateMap<ColorCreateDto, Color>();
            CreateMap<ColorUpdateDto,Color>().ReverseMap();
        }
    }
}
