using _02___AutoMapper;
using AutoMapper;

var config = new MapperConfiguration(cfg =>
{
    cfg.AddProfile<AutoMapperProfile>();
});

IMapper mapper = config.CreateMapper();

var source = new SourceModel { Age = 20, Name = "Rodrigo Abreu" };

var destination = mapper.Map<DestinationModel>(source);

Console.WriteLine($"Nome: {destination.Nome}, Idade: {destination.Idade}");
