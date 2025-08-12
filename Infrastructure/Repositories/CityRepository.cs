using Infrastructure.Entities;
using Infrastructure.Interfaces.Repositories;
namespace Infrastructure.Repositories
{
	public class CityRepository : ICityRepository
	{
		public async Task<IEnumerable<CityEntity>> GetAsync()
		{
			return await Task.FromResult(LIST.ToList());
		}

		public async Task<CityEntity> GetAsync(long id)
		{
			return await Task.FromResult(LIST.ToList().FirstOrDefault(x => x.Id == id));
		}

		private List<CityEntity> LIST = new List<CityEntity>()
			{
				new CityEntity()
		{
			Id = 1,
					Name = "Afonso Cláudio",
					Active = false
				},
				new CityEntity()
		{
			Id = 2,
					Name = "Água Doce do Norte",
					Active = false
				},
				new CityEntity()
		{
			Id = 3,
					Name = "Águia Branca",
					Active = false
				},
				new CityEntity()
		{
			Id = 4,
					Name = "Alegre",
					Active = false
				},
				new CityEntity()
		{
			Id = 5,
					Name = "Alfredo Chaves",
					Active = false
				},
				new CityEntity()
		{
			Id = 6,
					Name = "Alto Rio Novo",
					Active = false
				},
				new CityEntity()
		{
			Id = 7,
					Name = "Anchieta",
					Active = false
				},
				new CityEntity()
		{
			Id = 8,
					Name = "Apiacá",
					Active = false
				},
				new CityEntity()
		{
			Id = 9,
					Name = "Aracruz",
					Active = false
				},
				new CityEntity()
		{
			Id = 10,
					Name = "Atilio Vivacqua",
					Active = false
				},
				new CityEntity()
		{
			Id = 11,
					Name = "Baixo Guandu",
					Active = false
				},
				new CityEntity()
		{
			Id = 12,
					Name = "Barra de São Francisco",
					Active = false
				},
				new CityEntity()
		{
			Id = 13,
					Name = "Boa Esperança",
					Active = false
				},
				new CityEntity()
		{
			Id = 14,
					Name = "Bom Jesus do Norte",
					Active = false
				},
				new CityEntity()
		{
			Id = 15,
					Name = "Brejetuba",
					Active = false
				},
				new CityEntity()
		{
			Id = 16,
					Name = "Cachoeiro de Itapemirim",
					Active = false
				},
				new CityEntity()
		{
			Id = 17,
					Name = "Cariacica",
					Active = false
				},
				new CityEntity()
		{
			Id = 18,
					Name = "Castelo",
					Active = false
				},
				new CityEntity()
		{
			Id = 19,
					Name = "Colatina",
					Active = false
				},
				new CityEntity()
		{
			Id = 20,
					Name = "Conceição da Barra",
					Active = false
				},
				new CityEntity()
		{
			Id = 21,
					Name = "Conceição do Castelo",
					Active = false
				},
				new CityEntity()
		{
			Id = 22,
					Name = "Divino de São Lourenço",
					Active = false
				},
				new CityEntity()
		{
			Id = 23,
					Name = "Domingos Martins",
					Active = false
				},
				new CityEntity()
		{
			Id = 24,
					Name = "Dores do Rio Preto",
					Active = false
				},
				new CityEntity()
		{
			Id = 25,
					Name = "Ecoporanga",
					Active = false
				},
				new CityEntity()
		{
			Id = 26,
					Name = "Fundão",
					Active = false
				},
				new CityEntity()
		{
			Id = 27,
					Name = "Governador Lindenberg",
					Active = false
				},
				new CityEntity()
		{
			Id = 28,
					Name = "Guaçuí",
					Active = false
				},
				new CityEntity()
		{
			Id = 29,
					Name = "Guarapari",
					Active = false
				},
				new CityEntity()
		{
			Id = 30,
					Name = "Ibatiba",
					Active = false
				},
				new CityEntity()
		{
			Id = 31,
					Name = "Ibiraçu",
					Active = false
				},
				new CityEntity()
		{
			Id = 32,
					Name = "Ibitirama",
					Active = false
				},
				new CityEntity()
		{
			Id = 33,
					Name = "Iconha",
					Active = false
				},
				new CityEntity()
		{
			Id = 34,
					Name = "Irupi",
					Active = false
				},
				new CityEntity()
		{
			Id = 35,
					Name = "Itaguaçu",
					Active = false
				},
				new CityEntity()
		{
			Id = 36,
					Name = "Itapemirim",
					Active = false
				},
				new CityEntity()
		{
			Id = 37,
					Name = "Itarana",
					Active = false
				},
				new CityEntity()
		{
			Id = 38,
					Name = "Iúna",
					Active = false
				},
				new CityEntity()
		{
			Id = 39,
					Name = "Jaguaré",
					Active = false
				},
				new CityEntity()
		{
			Id = 40,
					Name = "Jerônimo Monteiro",
					Active = false
				},
				new CityEntity()
		{
			Id = 41,
					Name = "João Neiva",
					Active = false
				},
				new CityEntity()
		{
			Id = 42,
					Name = "Laranja da Terra",
					Active = false
				},
				new CityEntity()
		{
			Id = 43,
					Name = "Linhares",
					Active = false
				},
				new CityEntity()
		{
			Id = 44,
					Name = "Mantenópolis",
					Active = false
				},
				new CityEntity()
		{
			Id = 45,
					Name = "Marataízes",
					Active = false
				},
				new CityEntity()
		{
			Id = 46,
					Name = "Marechal Floriano",
					Active = false
				},
				new CityEntity()
		{
			Id = 47,
					Name = "Marilândia",
					Active = false
				},
				new CityEntity()
		{
			Id = 48,
					Name = "Mimoso do Sul",
					Active = false
				},
				new CityEntity()
		{
			Id = 49,
					Name = "Montanha",
					Active = false
				},
				new CityEntity()
		{
			Id = 50,
					Name = "Mucurici",
					Active = false
				},
				new CityEntity()
		{
			Id = 51,
					Name = "Muniz Freire",
					Active = false
				},
				new CityEntity()
		{
			Id = 52,
					Name = "Muqui",
					Active = false
				},
				new CityEntity()
		{
			Id = 53,
					Name = "Nova Venécia",
					Active = false
				},
				new CityEntity()
		{
			Id = 54,
					Name = "Pancas",
					Active = false
				},
				new CityEntity()
		{
			Id = 55,
					Name = "Pedro Canário",
					Active = false
				},
				new CityEntity()
		{
			Id = 56,
					Name = "Pinheiros",
					Active = false
				},
				new CityEntity()
		{
			Id = 57,
					Name = "Piúma",
					Active = false
				},
				new CityEntity()
		{
			Id = 58,
					Name = "Ponto Belo",
					Active = false
				},
				new CityEntity()
		{
			Id = 59,
					Name = "Presidente Kennedy",
					Active = false
				},
				new CityEntity()
		{
			Id = 60,
					Name = "Rio Bananal",
					Active = false
				},
				new CityEntity()
		{
			Id = 61,
					Name = "Rio Novo do Sul",
					Active = false
				},
				new CityEntity()
		{
			Id = 62,
					Name = "Santa Leopoldina",
					Active = false
				},
				new CityEntity()
		{
			Id = 63,
					Name = "Santa Maria de Jetibá",
					Active = false
				},
				new CityEntity()
		{
			Id = 64,
					Name = "Santa Teresa",
					Active = false
				},
				new CityEntity()
		{
			Id = 65,
					Name = "São Domingos do Norte",
					Active = false
				},
				new CityEntity()
		{
			Id = 66,
					Name = "São Gabriel da Palha",
					Active = false
				},
				new CityEntity()
		{
			Id = 67,
					Name = "São José do Calçado",
					Active = false
				},
				new CityEntity()
		{
			Id = 68,
					Name = "São Mateus",
					Active = false
				},
				new CityEntity()
		{
			Id = 69,
					Name = "São Roque do Canaã",
					Active = false
				},
				new CityEntity()
		{
			Id = 70,
					Name = "Serra",
					Active = false
				},
				new CityEntity()
		{
			Id = 71,
					Name = "Sooretama",
					Active = false
				},
				new CityEntity()
		{
			Id = 72,
					Name = "Vargem Alta",
					Active = false
				},
				new CityEntity()
		{
			Id = 73,
					Name = "Venda Nova do Imigrante",
					Active = false
				},
				new CityEntity()
		{
			Id = 74,
					Name = "Viana",
					Active = false
				},
				new CityEntity()
		{
			Id = 75,
					Name = "Vila Pavão",
					Active = false
				},
				new CityEntity()
		{
			Id = 76,
					Name = "Vila Valério",
					Active = false
				},
				new CityEntity()
		{
			Id = 77,
					Name = "Vila Velha",
					Active = false
				},
				new CityEntity()
		{
			Id = 78,
					Name = "Vitória",
					Active = false
				},
				new CityEntity()
		{
			Id = 79,
					Name = "Acrelândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 80,
					Name = "Assis Brasil",
					Active = false,
				},
				new CityEntity()
		{
			Id = 81,
					Name = "Brasiléia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 82,
					Name = "Bujari",
					Active = false,
				},
				new CityEntity()
		{
			Id = 83,
					Name = "Capixaba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 84,
					Name = "Cruzeiro do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 85,
					Name = "Epitaciolândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 86,
					Name = "Feijó",
					Active = false,
				},
				new CityEntity()
		{
			Id = 87,
					Name = "Jordão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 88,
					Name = "Mâncio Lima",
					Active = false,
				},
				new CityEntity()
		{
			Id = 89,
					Name = "Manoel Urbano",
					Active = false,
				},
				new CityEntity()
		{
			Id = 90,
					Name = "Marechal Thaumaturgo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 91,
					Name = "Plácido de Castro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 92,
					Name = "Porto Acre",
					Active = false,
				},
				new CityEntity()
		{
			Id = 93,
					Name = "Porto Walter",
					Active = false,
				},
				new CityEntity()
		{
			Id = 94,
					Name = "Rio Branco",
					Active = false,
				},
				new CityEntity()
		{
			Id = 95,
					Name = "Rodrigues Alves",
					Active = false,
				},
				new CityEntity()
		{
			Id = 96,
					Name = "Santa Rosa do Purus",
					Active = false,
				},
				new CityEntity()
		{
			Id = 97,
					Name = "Sena Madureira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 98,
					Name = "Senador Guiomard",
					Active = false,
				},
				new CityEntity()
		{
			Id = 99,
					Name = "Tarauacá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 100,
					Name = "Xapuri",
					Active = false,
				},
				new CityEntity()
		{
			Id = 101,
					Name = "Água Branca",
					Active = false,
				},
				new CityEntity()
		{
			Id = 102,
					Name = "Anadia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 103,
					Name = "Arapiraca",
					Active = false,
				},
				new CityEntity()
		{
			Id = 104,
					Name = "Atalaia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 105,
					Name = "Barra de Santo Antônio",
					Active = false,
				},
				new CityEntity()
		{
			Id = 106,
					Name = "Barra de São Miguel",
					Active = false,
				},
				new CityEntity()
		{
			Id = 107,
					Name = "Batalha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 108,
					Name = "Belém",
					Active = false,
				},
				new CityEntity()
		{
			Id = 109,
					Name = "Belo Monte",
					Active = false,
				},
				new CityEntity()
		{
			Id = 110,
					Name = "Boca da Mata",
					Active = false,
				},
				new CityEntity()
		{
			Id = 111,
					Name = "Branquinha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 112,
					Name = "Cacimbinhas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 113,
					Name = "Cajueiro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 114,
					Name = "Campestre",
					Active = false,
				},
				new CityEntity()
		{
			Id = 115,
					Name = "Campo Alegre",
					Active = false,
				},
				new CityEntity()
		{
			Id = 116,
					Name = "Campo Grande",
					Active = false,
				},
				new CityEntity()
		{
			Id = 117,
					Name = "Canapi",
					Active = false,
				},
				new CityEntity()
		{
			Id = 118,
					Name = "Capela",
					Active = false,
				},
				new CityEntity()
		{
			Id = 119,
					Name = "Carneiros",
					Active = false,
				},
				new CityEntity()
		{
			Id = 120,
					Name = "Chã Preta",
					Active = false,
				},
				new CityEntity()
		{
			Id = 121,
					Name = "Coité do Nóia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 122,
					Name = "Colônia Leopoldina",
					Active = false,
				},
				new CityEntity()
		{
			Id = 123,
					Name = "Coqueiro Seco",
					Active = false,
				},
				new CityEntity()
		{
			Id = 124,
					Name = "Coruripe",
					Active = false,
				},
				new CityEntity()
		{
			Id = 125,
					Name = "Craíbas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 126,
					Name = "Delmiro Gouveia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 127,
					Name = "Dois Riachos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 128,
					Name = "Estrela de Alagoas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 129,
					Name = "Feira Grande",
					Active = false,
				},
				new CityEntity()
		{
			Id = 130,
					Name = "Feliz Deserto",
					Active = false,
				},
				new CityEntity()
		{
			Id = 131,
					Name = "Flexeiras",
					Active = false,
				},
				new CityEntity()
		{
			Id = 132,
					Name = "Girau do Ponciano",
					Active = false,
				},
				new CityEntity()
		{
			Id = 133,
					Name = "Ibateguara",
					Active = false,
				},
				new CityEntity()
		{
			Id = 134,
					Name = "Igaci",
					Active = false,
				},
				new CityEntity()
		{
			Id = 135,
					Name = "Igreja Nova",
					Active = false,
				},
				new CityEntity()
		{
			Id = 136,
					Name = "Inhapi",
					Active = false,
				},
				new CityEntity()
		{
			Id = 137,
					Name = "Jacaré dos Homens",
					Active = false,
				},
				new CityEntity()
		{
			Id = 138,
					Name = "Jacuípe",
					Active = false,
				},
				new CityEntity()
		{
			Id = 139,
					Name = "Japaratinga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 140,
					Name = "Jaramataia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 141,
					Name = "Jequiá da Praia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 142,
					Name = "Joaquim Gomes",
					Active = false,
				},
				new CityEntity()
		{
			Id = 143,
					Name = "Jundiá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 144,
					Name = "Junqueiro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 145,
					Name = "Lagoa da Canoa",
					Active = false,
				},
				new CityEntity()
		{
			Id = 146,
					Name = "Limoeiro de Anadia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 147,
					Name = "Maceió",
					Active = false,
				},
				new CityEntity()
		{
			Id = 148,
					Name = "Major Isidoro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 149,
					Name = "Mar Vermelho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 150,
					Name = "Maragogi",
					Active = false,
				},
				new CityEntity()
		{
			Id = 151,
					Name = "Maravilha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 152,
					Name = "Marechal Deodoro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 153,
					Name = "Maribondo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 154,
					Name = "Mata Grande",
					Active = false,
				},
				new CityEntity()
		{
			Id = 155,
					Name = "Matriz de Camaragibe",
					Active = false,
				},
				new CityEntity()
		{
			Id = 156,
					Name = "Messias",
					Active = false,
				},
				new CityEntity()
		{
			Id = 157,
					Name = "Minador do Negrão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 158,
					Name = "Monteirópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 159,
					Name = "Murici",
					Active = false,
				},
				new CityEntity()
		{
			Id = 160,
					Name = "Novo Lino",
					Active = false,
				},
				new CityEntity()
		{
			Id = 161,
					Name = "Olho d`Água das Flores",
					Active = false,
				},
				new CityEntity()
		{
			Id = 162,
					Name = "Olho d`Água do Casado",
					Active = false,
				},
				new CityEntity()
		{
			Id = 163,
					Name = "Olho d`Água Grande",
					Active = false,
				},
				new CityEntity()
		{
			Id = 164,
					Name = "Olivença",
					Active = false,
				},
				new CityEntity()
		{
			Id = 165,
					Name = "Ouro Branco",
					Active = false,
				},
				new CityEntity()
		{
			Id = 166,
					Name = "Palestina",
					Active = false,
				},
				new CityEntity()
		{
			Id = 167,
					Name = "Palmeira dos Índios",
					Active = false,
				},
				new CityEntity()
		{
			Id = 168,
					Name = "Pão de Açúcar",
					Active = false,
				},
				new CityEntity()
		{
			Id = 169,
					Name = "Pariconha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 170,
					Name = "Paripueira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 171,
					Name = "Passo de Camaragibe",
					Active = false,
				},
				new CityEntity()
		{
			Id = 172,
					Name = "Paulo Jacinto",
					Active = false,
				},
				new CityEntity()
		{
			Id = 173,
					Name = "Penedo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 174,
					Name = "Piaçabuçu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 175,
					Name = "Pilar",
					Active = false,
				},
				new CityEntity()
		{
			Id = 176,
					Name = "Pindoba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 177,
					Name = "Piranhas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 178,
					Name = "Poço das Trincheiras",
					Active = false,
				},
				new CityEntity()
		{
			Id = 179,
					Name = "Porto Calvo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 180,
					Name = "Porto de Pedras",
					Active = false,
				},
				new CityEntity()
		{
			Id = 181,
					Name = "Porto Real do Colégio",
					Active = false,
				},
				new CityEntity()
		{
			Id = 182,
					Name = "Quebrangulo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 183,
					Name = "Rio Largo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 184,
					Name = "Roteiro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 185,
					Name = "Santa Luzia do Norte",
					Active = false,
				},
				new CityEntity()
		{
			Id = 186,
					Name = "Santana do Ipanema",
					Active = false,
				},
				new CityEntity()
		{
			Id = 187,
					Name = "Santana do Mundaú",
					Active = false,
				},
				new CityEntity()
		{
			Id = 188,
					Name = "São Brás",
					Active = false,
				},
				new CityEntity()
		{
			Id = 189,
					Name = "São José da Laje",
					Active = false,
				},
				new CityEntity()
		{
			Id = 190,
					Name = "São José da Tapera",
					Active = false,
				},
				new CityEntity()
		{
			Id = 191,
					Name = "São Luís do Quitunde",
					Active = false,
				},
				new CityEntity()
		{
			Id = 192,
					Name = "São Miguel dos Campos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 193,
					Name = "São Miguel dos Milagres",
					Active = false,
				},
				new CityEntity()
		{
			Id = 194,
					Name = "São Sebastião",
					Active = false,
				},
				new CityEntity()
		{
			Id = 195,
					Name = "Satuba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 196,
					Name = "Senador Rui Palmeira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 197,
					Name = "Tanque d`Arca",
					Active = false,
				},
				new CityEntity()
		{
			Id = 198,
					Name = "Taquarana",
					Active = false,
				},
				new CityEntity()
		{
			Id = 199,
					Name = "Teotônio Vilela",
					Active = false,
				},
				new CityEntity()
		{
			Id = 200,
					Name = "Traipu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 201,
					Name = "União dos Palmares",
					Active = false,
				},
				new CityEntity()
		{
			Id = 202,
					Name = "Viçosa",
					Active = false,
				},
				new CityEntity()
		{
			Id = 203,
					Name = "Amapá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 204,
					Name = "Calçoene",
					Active = false,
				},
				new CityEntity()
		{
			Id = 205,
					Name = "Cutias",
					Active = false,
				},
				new CityEntity()
		{
			Id = 206,
					Name = "Ferreira Gomes",
					Active = false,
				},
				new CityEntity()
		{
			Id = 207,
					Name = "Itaubal",
					Active = false,
				},
				new CityEntity()
		{
			Id = 208,
					Name = "Laranjal do Jari",
					Active = false,
				},
				new CityEntity()
		{
			Id = 209,
					Name = "Macapá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 210,
					Name = "Mazagão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 211,
					Name = "Oiapoque",
					Active = false,
				},
				new CityEntity()
		{
			Id = 212,
					Name = "Pedra Branca do Amaparí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 213,
					Name = "Porto Grande",
					Active = false,
				},
				new CityEntity()
		{
			Id = 214,
					Name = "Pracuúba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 215,
					Name = "Santana",
					Active = false,
				},
				new CityEntity()
		{
			Id = 216,
					Name = "Serra do Navio",
					Active = false,
				},
				new CityEntity()
		{
			Id = 217,
					Name = "Tartarugalzinho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 218,
					Name = "Vitória do Jari",
					Active = false,
				},
				new CityEntity()
		{
			Id = 219,
					Name = "Alvarães",
					Active = false,
				},
				new CityEntity()
		{
			Id = 220,
					Name = "Amaturá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 221,
					Name = "Anamã",
					Active = false,
				},
				new CityEntity()
		{
			Id = 222,
					Name = "Anori",
					Active = false,
				},
				new CityEntity()
		{
			Id = 223,
					Name = "Apuí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 224,
					Name = "Atalaia do Norte",
					Active = false,
				},
				new CityEntity()
		{
			Id = 225,
					Name = "Autazes",
					Active = false,
				},
				new CityEntity()
		{
			Id = 226,
					Name = "Barcelos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 227,
					Name = "Barreirinha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 228,
					Name = "Benjamin Constant",
					Active = false,
				},
				new CityEntity()
		{
			Id = 229,
					Name = "Beruri",
					Active = false,
				},
				new CityEntity()
		{
			Id = 230,
					Name = "Boa Vista do Ramos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 231,
					Name = "Boca do Acre",
					Active = false,
				},
				new CityEntity()
		{
			Id = 232,
					Name = "Borba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 233,
					Name = "Caapiranga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 234,
					Name = "Canutama",
					Active = false,
				},
				new CityEntity()
		{
			Id = 235,
					Name = "Carauari",
					Active = false,
				},
				new CityEntity()
		{
			Id = 236,
					Name = "Careiro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 237,
					Name = "Careiro da Várzea",
					Active = false,
				},
				new CityEntity()
		{
			Id = 238,
					Name = "Coari",
					Active = false,
				},
				new CityEntity()
		{
			Id = 239,
					Name = "Codajás",
					Active = false,
				},
				new CityEntity()
		{
			Id = 240,
					Name = "Eirunepé",
					Active = false,
				},
				new CityEntity()
		{
			Id = 241,
					Name = "Envira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 242,
					Name = "Fonte Boa",
					Active = false,
				},
				new CityEntity()
		{
			Id = 243,
					Name = "Guajará",
					Active = false,
				},
				new CityEntity()
		{
			Id = 244,
					Name = "Humaitá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 245,
					Name = "Ipixuna",
					Active = false,
				},
				new CityEntity()
		{
			Id = 246,
					Name = "Iranduba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 247,
					Name = "Itacoatiara",
					Active = false,
				},
				new CityEntity()
		{
			Id = 248,
					Name = "Itamarati",
					Active = false,
				},
				new CityEntity()
		{
			Id = 249,
					Name = "Itapiranga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 250,
					Name = "Japurá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 251,
					Name = "Juruá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 252,
					Name = "Jutaí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 253,
					Name = "Lábrea",
					Active = false,
				},
				new CityEntity()
		{
			Id = 254,
					Name = "Manacapuru",
					Active = false,
				},
				new CityEntity()
		{
			Id = 255,
					Name = "Manaquiri",
					Active = false,
				},
				new CityEntity()
		{
			Id = 256,
					Name = "Manaus",
					Active = false,
				},
				new CityEntity()
		{
			Id = 257,
					Name = "Manicoré",
					Active = false,
				},
				new CityEntity()
		{
			Id = 258,
					Name = "Maraã",
					Active = false,
				},
				new CityEntity()
		{
			Id = 259,
					Name = "Maués",
					Active = false,
				},
				new CityEntity()
		{
			Id = 260,
					Name = "Nhamundá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 261,
					Name = "Nova Olinda do Norte",
					Active = false,
				},
				new CityEntity()
		{
			Id = 262,
					Name = "Novo Airão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 263,
					Name = "Novo Aripuanã",
					Active = false,
				},
				new CityEntity()
		{
			Id = 264,
					Name = "Parintins",
					Active = false,
				},
				new CityEntity()
		{
			Id = 265,
					Name = "Pauini",
					Active = false,
				},
				new CityEntity()
		{
			Id = 266,
					Name = "Presidente Figueiredo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 267,
					Name = "Rio Preto da Eva",
					Active = false,
				},
				new CityEntity()
		{
			Id = 268,
					Name = "Santa Isabel do Rio Negro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 269,
					Name = "Santo Antônio do Içá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 270,
					Name = "São Gabriel da Cachoeira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 271,
					Name = "São Paulo de Olivença",
					Active = false,
				},
				new CityEntity()
		{
			Id = 272,
					Name = "São Sebastião do Uatumã",
					Active = false,
				},
				new CityEntity()
		{
			Id = 273,
					Name = "Silves",
					Active = false,
				},
				new CityEntity()
		{
			Id = 274,
					Name = "Tabatinga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 275,
					Name = "Tapauá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 276,
					Name = "Tefé",
					Active = false,
				},
				new CityEntity()
		{
			Id = 277,
					Name = "Tonantins",
					Active = false,
				},
				new CityEntity()
		{
			Id = 278,
					Name = "Uarini",
					Active = false,
				},
				new CityEntity()
		{
			Id = 279,
					Name = "Urucará",
					Active = false,
				},
				new CityEntity()
		{
			Id = 280,
					Name = "Urucurituba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 281,
					Name = "Abaíra",
					Active = false,
				},
				new CityEntity()
		{
			Id = 282,
					Name = "Abaré",
					Active = false,
				},
				new CityEntity()
		{
			Id = 283,
					Name = "Acajutiba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 284,
					Name = "Adustina",
					Active = false,
				},
				new CityEntity()
		{
			Id = 285,
					Name = "Água Fria",
					Active = false,
				},
				new CityEntity()
		{
			Id = 286,
					Name = "Aiquara",
					Active = false,
				},
				new CityEntity()
		{
			Id = 287,
					Name = "Alagoinhas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 288,
					Name = "Alcobaça",
					Active = false,
				},
				new CityEntity()
		{
			Id = 289,
					Name = "Almadina",
					Active = false,
				},
				new CityEntity()
		{
			Id = 290,
					Name = "Amargosa",
					Active = false,
				},
				new CityEntity()
		{
			Id = 291,
					Name = "Amélia Rodrigues",
					Active = false,
				},
				new CityEntity()
		{
			Id = 292,
					Name = "América Dourada",
					Active = false,
				},
				new CityEntity()
		{
			Id = 293,
					Name = "Anagé",
					Active = false,
				},
				new CityEntity()
		{
			Id = 294,
					Name = "Andaraí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 295,
					Name = "Andorinha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 296,
					Name = "Angical",
					Active = false,
				},
				new CityEntity()
		{
			Id = 297,
					Name = "Anguera",
					Active = false,
				},
				new CityEntity()
		{
			Id = 298,
					Name = "Antas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 299,
					Name = "Antônio Cardoso",
					Active = false,
				},
				new CityEntity()
		{
			Id = 300,
					Name = "Antônio Gonçalves",
					Active = false,
				},
				new CityEntity()
		{
			Id = 301,
					Name = "Aporá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 302,
					Name = "Apuarema",
					Active = false,
				},
				new CityEntity()
		{
			Id = 303,
					Name = "Araças",
					Active = false,
				},
				new CityEntity()
		{
			Id = 304,
					Name = "Aracatu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 305,
					Name = "Araci",
					Active = false,
				},
				new CityEntity()
		{
			Id = 306,
					Name = "Aramari",
					Active = false,
				},
				new CityEntity()
		{
			Id = 307,
					Name = "Arataca",
					Active = false,
				},
				new CityEntity()
		{
			Id = 308,
					Name = "Aratuípe",
					Active = false,
				},
				new CityEntity()
		{
			Id = 309,
					Name = "Aurelino Leal",
					Active = false,
				},
				new CityEntity()
		{
			Id = 310,
					Name = "Baianópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 311,
					Name = "Baixa Grande",
					Active = false,
				},
				new CityEntity()
		{
			Id = 312,
					Name = "Banzaê",
					Active = false,
				},
				new CityEntity()
		{
			Id = 313,
					Name = "Barra",
					Active = false,
				},
				new CityEntity()
		{
			Id = 314,
					Name = "Barra da Estiva",
					Active = false,
				},
				new CityEntity()
		{
			Id = 315,
					Name = "Barra do Choça",
					Active = false,
				},
				new CityEntity()
		{
			Id = 316,
					Name = "Barra do Mendes",
					Active = false,
				},
				new CityEntity()
		{
			Id = 317,
					Name = "Barra do Rocha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 318,
					Name = "Barreiras",
					Active = false,
				},
				new CityEntity()
		{
			Id = 319,
					Name = "Barro Alto",
					Active = false,
				},
				new CityEntity()
		{
			Id = 320,
					Name = "Barro Preto (antigo Gov. Lomanto Jr.)",
					Active = false,
				},
				new CityEntity()
		{
			Id = 321,
					Name = "Barrocas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 322,
					Name = "Belmonte",
					Active = false,
				},
				new CityEntity()
		{
			Id = 323,
					Name = "Belo Campo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 324,
					Name = "Biritinga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 325,
					Name = "Boa Nova",
					Active = false,
				},
				new CityEntity()
		{
			Id = 326,
					Name = "Boa Vista do Tupim",
					Active = false,
				},
				new CityEntity()
		{
			Id = 327,
					Name = "Bom Jesus da Lapa",
					Active = false,
				},
				new CityEntity()
		{
			Id = 328,
					Name = "Bom Jesus da Serra",
					Active = false,
				},
				new CityEntity()
		{
			Id = 329,
					Name = "Boninal",
					Active = false,
				},
				new CityEntity()
		{
			Id = 330,
					Name = "Bonito",
					Active = false,
				},
				new CityEntity()
		{
			Id = 331,
					Name = "Boquira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 332,
					Name = "Botuporã",
					Active = false,
				},
				new CityEntity()
		{
			Id = 333,
					Name = "Brejões",
					Active = false,
				},
				new CityEntity()
		{
			Id = 334,
					Name = "Brejolândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 335,
					Name = "Brotas de Macaúbas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 336,
					Name = "Brumado",
					Active = false,
				},
				new CityEntity()
		{
			Id = 337,
					Name = "Buerarema",
					Active = false,
				},
				new CityEntity()
		{
			Id = 338,
					Name = "Buritirama",
					Active = false,
				},
				new CityEntity()
		{
			Id = 339,
					Name = "Caatiba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 340,
					Name = "Cabaceiras do Paraguaçu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 341,
					Name = "Cachoeira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 342,
					Name = "Caculé",
					Active = false,
				},
				new CityEntity()
		{
			Id = 343,
					Name = "Caém",
					Active = false,
				},
				new CityEntity()
		{
			Id = 344,
					Name = "Caetanos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 345,
					Name = "Caetité",
					Active = false,
				},
				new CityEntity()
		{
			Id = 346,
					Name = "Cafarnaum",
					Active = false,
				},
				new CityEntity()
		{
			Id = 347,
					Name = "Cairu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 348,
					Name = "Caldeirão Grande",
					Active = false,
				},
				new CityEntity()
		{
			Id = 349,
					Name = "Camacan",
					Active = false,
				},
				new CityEntity()
		{
			Id = 350,
					Name = "Camaçari",
					Active = false,
				},
				new CityEntity()
		{
			Id = 351,
					Name = "Camamu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 352,
					Name = "Campo Alegre de Lourdes",
					Active = false,
				},
				new CityEntity()
		{
			Id = 353,
					Name = "Campo Formoso",
					Active = false,
				},
				new CityEntity()
		{
			Id = 354,
					Name = "Canápolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 355,
					Name = "Canarana",
					Active = false,
				},
				new CityEntity()
		{
			Id = 356,
					Name = "Canavieiras",
					Active = false,
				},
				new CityEntity()
		{
			Id = 357,
					Name = "Candeal",
					Active = false,
				},
				new CityEntity()
		{
			Id = 358,
					Name = "Candeias",
					Active = false,
				},
				new CityEntity()
		{
			Id = 359,
					Name = "Candiba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 360,
					Name = "Cândido Sales",
					Active = false,
				},
				new CityEntity()
		{
			Id = 361,
					Name = "Cansanção",
					Active = false,
				},
				new CityEntity()
		{
			Id = 362,
					Name = "Canudos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 363,
					Name = "Capela do Alto Alegre",
					Active = false,
				},
				new CityEntity()
		{
			Id = 364,
					Name = "Capim Grosso",
					Active = false,
				},
				new CityEntity()
		{
			Id = 365,
					Name = "Caraíbas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 366,
					Name = "Caravelas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 367,
					Name = "Cardeal da Silva",
					Active = false,
				},
				new CityEntity()
		{
			Id = 368,
					Name = "Carinhanha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 369,
					Name = "Casa Nova",
					Active = false,
				},
				new CityEntity()
		{
			Id = 370,
					Name = "Castro Alves",
					Active = false,
				},
				new CityEntity()
		{
			Id = 371,
					Name = "Catolândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 372,
					Name = "Catu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 373,
					Name = "Caturama",
					Active = false,
				},
				new CityEntity()
		{
			Id = 374,
					Name = "Central",
					Active = false,
				},
				new CityEntity()
		{
			Id = 375,
					Name = "Chorrochó",
					Active = false,
				},
				new CityEntity()
		{
			Id = 376,
					Name = "Cícero Dantas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 377,
					Name = "Cipó",
					Active = false,
				},
				new CityEntity()
		{
			Id = 378,
					Name = "Coaraci",
					Active = false,
				},
				new CityEntity()
		{
			Id = 379,
					Name = "Cocos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 380,
					Name = "Conceição da Feira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 381,
					Name = "Conceição do Almeida",
					Active = false,
				},
				new CityEntity()
		{
			Id = 382,
					Name = "Conceição do Coité",
					Active = false,
				},
				new CityEntity()
		{
			Id = 383,
					Name = "Conceição do Jacuípe",
					Active = false,
				},
				new CityEntity()
		{
			Id = 384,
					Name = "Conde",
					Active = false,
				},
				new CityEntity()
		{
			Id = 385,
					Name = "Condeúba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 386,
					Name = "Contendas do Sincorá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 387,
					Name = "Coração de Maria",
					Active = false,
				},
				new CityEntity()
		{
			Id = 388,
					Name = "Cordeiros",
					Active = false,
				},
				new CityEntity()
		{
			Id = 389,
					Name = "Coribe",
					Active = false,
				},
				new CityEntity()
		{
			Id = 390,
					Name = "Coronel João Sá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 391,
					Name = "Correntina",
					Active = false,
				},
				new CityEntity()
		{
			Id = 392,
					Name = "Cotegipe",
					Active = false,
				},
				new CityEntity()
		{
			Id = 393,
					Name = "Cravolândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 394,
					Name = "Crisópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 395,
					Name = "Cristópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 396,
					Name = "Cruz das Almas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 397,
					Name = "Curaçá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 398,
					Name = "Dário Meira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 399,
					Name = "Dias d`Ávila",
					Active = false,
				},
				new CityEntity()
		{
			Id = 400,
					Name = "Dom Basílio",
					Active = false,
				},
				new CityEntity()
		{
			Id = 401,
					Name = "Dom Macedo Costa",
					Active = false,
				},
				new CityEntity()
		{
			Id = 402,
					Name = "Elísio Medrado",
					Active = false,
				},
				new CityEntity()
		{
			Id = 403,
					Name = "Encruzilhada",
					Active = false,
				},
				new CityEntity()
		{
			Id = 404,
					Name = "Entre Rios",
					Active = false,
				},
				new CityEntity()
		{
			Id = 405,
					Name = "Érico Cardoso",
					Active = false,
				},
				new CityEntity()
		{
			Id = 406,
					Name = "Esplanada",
					Active = false,
				},
				new CityEntity()
		{
			Id = 407,
					Name = "Euclides da Cunha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 408,
					Name = "Eunápolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 409,
					Name = "Fátima",
					Active = false,
				},
				new CityEntity()
		{
			Id = 410,
					Name = "Feira da Mata",
					Active = false,
				},
				new CityEntity()
		{
			Id = 411,
					Name = "Feira de Santana",
					Active = false,
				},
				new CityEntity()
		{
			Id = 412,
					Name = "Filadélfia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 413,
					Name = "Firmino Alves",
					Active = false,
				},
				new CityEntity()
		{
			Id = 414,
					Name = "Floresta Azul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 415,
					Name = "Formosa do Rio Preto",
					Active = false,
				},
				new CityEntity()
		{
			Id = 416,
					Name = "Gandu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 417,
					Name = "Gavião",
					Active = false,
				},
				new CityEntity()
		{
			Id = 418,
					Name = "Gentio do Ouro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 419,
					Name = "Glória",
					Active = false,
				},
				new CityEntity()
		{
			Id = 420,
					Name = "Gongogi",
					Active = false,
				},
				new CityEntity()
		{
			Id = 421,
					Name = "Governador Mangabeira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 422,
					Name = "Guajeru",
					Active = false,
				},
				new CityEntity()
		{
			Id = 423,
					Name = "Guanambi",
					Active = false,
				},
				new CityEntity()
		{
			Id = 424,
					Name = "Guaratinga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 425,
					Name = "Heliópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 426,
					Name = "Iaçu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 427,
					Name = "Ibiassucê",
					Active = false,
				},
				new CityEntity()
		{
			Id = 428,
					Name = "Ibicaraí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 429,
					Name = "Ibicoara",
					Active = false,
				},
				new CityEntity()
		{
			Id = 430,
					Name = "Ibicuí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 431,
					Name = "Ibipeba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 432,
					Name = "Ibipitanga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 433,
					Name = "Ibiquera",
					Active = false,
				},
				new CityEntity()
		{
			Id = 434,
					Name = "Ibirapitanga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 435,
					Name = "Ibirapuã",
					Active = false,
				},
				new CityEntity()
		{
			Id = 436,
					Name = "Ibirataia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 437,
					Name = "Ibitiara",
					Active = false,
				},
				new CityEntity()
		{
			Id = 438,
					Name = "Ibititá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 439,
					Name = "Ibotirama",
					Active = false,
				},
				new CityEntity()
		{
			Id = 440,
					Name = "Ichu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 441,
					Name = "Igaporã",
					Active = false,
				},
				new CityEntity()
		{
			Id = 442,
					Name = "Igrapiúna",
					Active = false,
				},
				new CityEntity()
		{
			Id = 443,
					Name = "Iguaí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 444,
					Name = "Ilhéus",
					Active = false,
				},
				new CityEntity()
		{
			Id = 445,
					Name = "Inhambupe",
					Active = false,
				},
				new CityEntity()
		{
			Id = 446,
					Name = "Ipecaetá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 447,
					Name = "Ipiaú",
					Active = false,
				},
				new CityEntity()
		{
			Id = 448,
					Name = "Ipirá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 449,
					Name = "Ipupiara",
					Active = false,
				},
				new CityEntity()
		{
			Id = 450,
					Name = "Irajuba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 451,
					Name = "Iramaia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 452,
					Name = "Iraquara",
					Active = false,
				},
				new CityEntity()
		{
			Id = 453,
					Name = "Irará",
					Active = false,
				},
				new CityEntity()
		{
			Id = 454,
					Name = "Irecê",
					Active = false,
				},
				new CityEntity()
		{
			Id = 455,
					Name = "Itabela",
					Active = false,
				},
				new CityEntity()
		{
			Id = 456,
					Name = "Itaberaba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 457,
					Name = "Itabuna",
					Active = false,
				},
				new CityEntity()
		{
			Id = 458,
					Name = "Itacaré",
					Active = false,
				},
				new CityEntity()
		{
			Id = 459,
					Name = "Itaeté",
					Active = false,
				},
				new CityEntity()
		{
			Id = 460,
					Name = "Itagi",
					Active = false,
				},
				new CityEntity()
		{
			Id = 461,
					Name = "Itagibá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 462,
					Name = "Itagimirim",
					Active = false,
				},
				new CityEntity()
		{
			Id = 463,
					Name = "Itaguaçu da Bahia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 464,
					Name = "Itaju do Colônia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 465,
					Name = "Itajuípe",
					Active = false,
				},
				new CityEntity()
		{
			Id = 466,
					Name = "Itamaraju",
					Active = false,
				},
				new CityEntity()
		{
			Id = 467,
					Name = "Itamari",
					Active = false,
				},
				new CityEntity()
		{
			Id = 468,
					Name = "Itambé",
					Active = false,
				},
				new CityEntity()
		{
			Id = 469,
					Name = "Itanagra",
					Active = false,
				},
				new CityEntity()
		{
			Id = 470,
					Name = "Itanhém",
					Active = false,
				},
				new CityEntity()
		{
			Id = 471,
					Name = "Itaparica",
					Active = false,
				},
				new CityEntity()
		{
			Id = 472,
					Name = "Itapé",
					Active = false,
				},
				new CityEntity()
		{
			Id = 473,
					Name = "Itapebi",
					Active = false,
				},
				new CityEntity()
		{
			Id = 474,
					Name = "Itapetinga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 475,
					Name = "Itapicuru",
					Active = false,
				},
				new CityEntity()
		{
			Id = 476,
					Name = "Itapitanga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 477,
					Name = "Itaquara",
					Active = false,
				},
				new CityEntity()
		{
			Id = 478,
					Name = "Itarantim",
					Active = false,
				},
				new CityEntity()
		{
			Id = 479,
					Name = "Itatim",
					Active = false,
				},
				new CityEntity()
		{
			Id = 480,
					Name = "Itiruçu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 481,
					Name = "Itiúba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 482,
					Name = "Itororó",
					Active = false,
				},
				new CityEntity()
		{
			Id = 483,
					Name = "Ituaçu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 484,
					Name = "Ituberá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 485,
					Name = "Iuiú",
					Active = false,
				},
				new CityEntity()
		{
			Id = 486,
					Name = "Jaborandi",
					Active = false,
				},
				new CityEntity()
		{
			Id = 487,
					Name = "Jacaraci",
					Active = false,
				},
				new CityEntity()
		{
			Id = 488,
					Name = "Jacobina",
					Active = false,
				},
				new CityEntity()
		{
			Id = 489,
					Name = "Jaguaquara",
					Active = false,
				},
				new CityEntity()
		{
			Id = 490,
					Name = "Jaguarari",
					Active = false,
				},
				new CityEntity()
		{
			Id = 491,
					Name = "Jaguaripe",
					Active = false,
				},
				new CityEntity()
		{
			Id = 492,
					Name = "Jandaíra",
					Active = false,
				},
				new CityEntity()
		{
			Id = 493,
					Name = "Jequié",
					Active = false,
				},
				new CityEntity()
		{
			Id = 494,
					Name = "Jeremoabo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 495,
					Name = "Jiquiriçá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 496,
					Name = "Jitaúna",
					Active = false,
				},
				new CityEntity()
		{
			Id = 497,
					Name = "João Dourado",
					Active = false,
				},
				new CityEntity()
		{
			Id = 498,
					Name = "Juazeiro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 499,
					Name = "Jucuruçu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 500,
					Name = "Jussara",
					Active = false,
				},
				new CityEntity()
		{
			Id = 501,
					Name = "Jussari",
					Active = false,
				},
				new CityEntity()
		{
			Id = 502,
					Name = "Jussiape",
					Active = false,
				},
				new CityEntity()
		{
			Id = 503,
					Name = "Lafaiete Coutinho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 504,
					Name = "Lagoa Real",
					Active = false,
				},
				new CityEntity()
		{
			Id = 505,
					Name = "Laje",
					Active = false,
				},
				new CityEntity()
		{
			Id = 506,
					Name = "Lajedão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 507,
					Name = "Lajedinho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 508,
					Name = "Lajedo do Tabocal",
					Active = false,
				},
				new CityEntity()
		{
			Id = 509,
					Name = "Lamarão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 510,
					Name = "Lapão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 511,
					Name = "Lauro de Freitas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 512,
					Name = "Lençóis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 513,
					Name = "Licínio de Almeida",
					Active = false,
				},
				new CityEntity()
		{
			Id = 514,
					Name = "Livramento de Nossa Senhora",
					Active = false,
				},
				new CityEntity()
		{
			Id = 515,
					Name = "Luís Eduardo Magalhães",
					Active = false,
				},
				new CityEntity()
		{
			Id = 516,
					Name = "Macajuba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 517,
					Name = "Macarani",
					Active = false,
				},
				new CityEntity()
		{
			Id = 518,
					Name = "Macaúbas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 519,
					Name = "Macururé",
					Active = false,
				},
				new CityEntity()
		{
			Id = 520,
					Name = "Madre de Deus",
					Active = false,
				},
				new CityEntity()
		{
			Id = 521,
					Name = "Maetinga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 522,
					Name = "Maiquinique",
					Active = false,
				},
				new CityEntity()
		{
			Id = 523,
					Name = "Mairi",
					Active = false,
				},
				new CityEntity()
		{
			Id = 524,
					Name = "Malhada",
					Active = false,
				},
				new CityEntity()
		{
			Id = 525,
					Name = "Malhada de Pedras",
					Active = false,
				},
				new CityEntity()
		{
			Id = 526,
					Name = "Manoel Vitorino",
					Active = false,
				},
				new CityEntity()
		{
			Id = 527,
					Name = "Mansidão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 528,
					Name = "Maracás",
					Active = false,
				},
				new CityEntity()
		{
			Id = 529,
					Name = "Maragogipe",
					Active = false,
				},
				new CityEntity()
		{
			Id = 530,
					Name = "Maraú",
					Active = false,
				},
				new CityEntity()
		{
			Id = 531,
					Name = "Marcionílio Souza",
					Active = false,
				},
				new CityEntity()
		{
			Id = 532,
					Name = "Mascote",
					Active = false,
				},
				new CityEntity()
		{
			Id = 533,
					Name = "Mata de São João",
					Active = false,
				},
				new CityEntity()
		{
			Id = 534,
					Name = "Matina",
					Active = false,
				},
				new CityEntity()
		{
			Id = 535,
					Name = "Medeiros Neto",
					Active = false,
				},
				new CityEntity()
		{
			Id = 536,
					Name = "Miguel Calmon",
					Active = false,
				},
				new CityEntity()
		{
			Id = 537,
					Name = "Milagres",
					Active = false,
				},
				new CityEntity()
		{
			Id = 538,
					Name = "Mirangaba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 539,
					Name = "Mirante",
					Active = false,
				},
				new CityEntity()
		{
			Id = 540,
					Name = "Monte Santo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 541,
					Name = "Morpará",
					Active = false,
				},
				new CityEntity()
		{
			Id = 542,
					Name = "Morro do Chapéu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 543,
					Name = "Mortugaba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 544,
					Name = "Mucugê",
					Active = false,
				},
				new CityEntity()
		{
			Id = 545,
					Name = "Mucuri",
					Active = false,
				},
				new CityEntity()
		{
			Id = 546,
					Name = "Mulungu do Morro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 547,
					Name = "Mundo Novo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 548,
					Name = "Muniz Ferreira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 549,
					Name = "Muquém de São Francisco",
					Active = false,
				},
				new CityEntity()
		{
			Id = 550,
					Name = "Muritiba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 551,
					Name = "Mutuípe",
					Active = false,
				},
				new CityEntity()
		{
			Id = 552,
					Name = "Nazaré",
					Active = false,
				},
				new CityEntity()
		{
			Id = 553,
					Name = "Nilo Peçanha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 554,
					Name = "Nordestina",
					Active = false,
				},
				new CityEntity()
		{
			Id = 555,
					Name = "Nova Canaã",
					Active = false,
				},
				new CityEntity()
		{
			Id = 556,
					Name = "Nova Fátima",
					Active = false,
				},
				new CityEntity()
		{
			Id = 557,
					Name = "Nova Ibiá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 558,
					Name = "Nova Itarana",
					Active = false,
				},
				new CityEntity()
		{
			Id = 559,
					Name = "Nova Redenção",
					Active = false,
				},
				new CityEntity()
		{
			Id = 560,
					Name = "Nova Soure",
					Active = false,
				},
				new CityEntity()
		{
			Id = 561,
					Name = "Nova Viçosa",
					Active = false,
				},
				new CityEntity()
		{
			Id = 562,
					Name = "Novo Horizonte",
					Active = false,
				},
				new CityEntity()
		{
			Id = 563,
					Name = "Novo Triunfo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 564,
					Name = "Olindina",
					Active = false,
				},
				new CityEntity()
		{
			Id = 565,
					Name = "Oliveira dos Brejinhos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 566,
					Name = "Ouriçangas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 567,
					Name = "Ourolândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 568,
					Name = "Palmas de Monte Alto",
					Active = false,
				},
				new CityEntity()
		{
			Id = 569,
					Name = "Palmeiras",
					Active = false,
				},
				new CityEntity()
		{
			Id = 570,
					Name = "Paramirim",
					Active = false,
				},
				new CityEntity()
		{
			Id = 571,
					Name = "Paratinga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 572,
					Name = "Paripiranga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 573,
					Name = "Pau Brasil",
					Active = false,
				},
				new CityEntity()
		{
			Id = 574,
					Name = "Paulo Afonso",
					Active = false,
				},
				new CityEntity()
		{
			Id = 575,
					Name = "Pé de Serra",
					Active = false,
				},
				new CityEntity()
		{
			Id = 576,
					Name = "Pedrão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 577,
					Name = "Pedro Alexandre",
					Active = false,
				},
				new CityEntity()
		{
			Id = 578,
					Name = "Piatã",
					Active = false,
				},
				new CityEntity()
		{
			Id = 579,
					Name = "Pilão Arcado",
					Active = false,
				},
				new CityEntity()
		{
			Id = 580,
					Name = "Pindaí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 581,
					Name = "Pindobaçu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 582,
					Name = "Pintadas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 583,
					Name = "Piraí do Norte",
					Active = false,
				},
				new CityEntity()
		{
			Id = 584,
					Name = "Piripá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 585,
					Name = "Piritiba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 586,
					Name = "Planaltino",
					Active = false,
				},
				new CityEntity()
		{
			Id = 587,
					Name = "Planalto",
					Active = false,
				},
				new CityEntity()
		{
			Id = 588,
					Name = "Poções",
					Active = false,
				},
				new CityEntity()
		{
			Id = 589,
					Name = "Pojuca",
					Active = false,
				},
				new CityEntity()
		{
			Id = 590,
					Name = "Ponto Novo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 591,
					Name = "Porto Seguro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 592,
					Name = "Potiraguá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 593,
					Name = "Prado",
					Active = false,
				},
				new CityEntity()
		{
			Id = 594,
					Name = "Presidente Dutra",
					Active = false,
				},
				new CityEntity()
		{
			Id = 595,
					Name = "Presidente Jânio Quadros",
					Active = false,
				},
				new CityEntity()
		{
			Id = 596,
					Name = "Presidente Tancredo Neves",
					Active = false,
				},
				new CityEntity()
		{
			Id = 597,
					Name = "Queimadas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 598,
					Name = "Quijingue",
					Active = false,
				},
				new CityEntity()
		{
			Id = 599,
					Name = "Quixabeira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 600,
					Name = "Rafael Jambeiro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 601,
					Name = "Remanso",
					Active = false,
				},
				new CityEntity()
		{
			Id = 602,
					Name = "Retirolândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 603,
					Name = "Riachão das Neves",
					Active = false,
				},
				new CityEntity()
		{
			Id = 604,
					Name = "Riachão do Jacuípe",
					Active = false,
				},
				new CityEntity()
		{
			Id = 605,
					Name = "Riacho de Santana",
					Active = false,
				},
				new CityEntity()
		{
			Id = 606,
					Name = "Ribeira do Amparo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 607,
					Name = "Ribeira do Pombal",
					Active = false,
				},
				new CityEntity()
		{
			Id = 608,
					Name = "Ribeirão do Largo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 609,
					Name = "Rio de Contas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 610,
					Name = "Rio do Antônio",
					Active = false,
				},
				new CityEntity()
		{
			Id = 611,
					Name = "Rio do Pires",
					Active = false,
				},
				new CityEntity()
		{
			Id = 612,
					Name = "Rio Real",
					Active = false,
				},
				new CityEntity()
		{
			Id = 613,
					Name = "Rodelas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 614,
					Name = "Ruy Barbosa",
					Active = false,
				},
				new CityEntity()
		{
			Id = 615,
					Name = "Salinas da Margarida",
					Active = false,
				},
				new CityEntity()
		{
			Id = 616,
					Name = "Salvador",
					Active = false,
				},
				new CityEntity()
		{
			Id = 617,
					Name = "Santa Bárbara",
					Active = false,
				},
				new CityEntity()
		{
			Id = 618,
					Name = "Santa Brígida",
					Active = false,
				},
				new CityEntity()
		{
			Id = 619,
					Name = "Santa Cruz Cabrália",
					Active = false,
				},
				new CityEntity()
		{
			Id = 620,
					Name = "Santa Cruz da Vitória",
					Active = false,
				},
				new CityEntity()
		{
			Id = 621,
					Name = "Santa Inês",
					Active = false,
				},
				new CityEntity()
		{
			Id = 622,
					Name = "Santa Luzia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 623,
					Name = "Santa Maria da Vitória",
					Active = false,
				},
				new CityEntity()
		{
			Id = 624,
					Name = "Santa Rita de Cássia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 625,
					Name = "Santa Teresinha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 626,
					Name = "Santaluz",
					Active = false,
				},
				new CityEntity()
		{
			Id = 627,
					Name = "Santana",
					Active = false,
				},
				new CityEntity()
		{
			Id = 628,
					Name = "Santanópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 629,
					Name = "Santo Amaro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 630,
					Name = "Santo Antônio de Jesus",
					Active = false,
				},
				new CityEntity()
		{
			Id = 631,
					Name = "Santo Estêvão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 632,
					Name = "São Desidério",
					Active = false,
				},
				new CityEntity()
		{
			Id = 633,
					Name = "São Domingos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 634,
					Name = "São Felipe",
					Active = false,
				},
				new CityEntity()
		{
			Id = 635,
					Name = "São Félix",
					Active = false,
				},
				new CityEntity()
		{
			Id = 636,
					Name = "São Félix do Coribe",
					Active = false,
				},
				new CityEntity()
		{
			Id = 637,
					Name = "São Francisco do Conde",
					Active = false,
				},
				new CityEntity()
		{
			Id = 638,
					Name = "São Gabriel",
					Active = false,
				},
				new CityEntity()
		{
			Id = 639,
					Name = "São Gonçalo dos Campos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 640,
					Name = "São José da Vitória",
					Active = false,
				},
				new CityEntity()
		{
			Id = 641,
					Name = "São José do Jacuípe",
					Active = false,
				},
				new CityEntity()
		{
			Id = 642,
					Name = "São Miguel das Matas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 643,
					Name = "São Sebastião do Passé",
					Active = false,
				},
				new CityEntity()
		{
			Id = 644,
					Name = "Sapeaçu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 645,
					Name = "Sátiro Dias",
					Active = false,
				},
				new CityEntity()
		{
			Id = 646,
					Name = "Saubara",
					Active = false,
				},
				new CityEntity()
		{
			Id = 647,
					Name = "Saúde",
					Active = false,
				},
				new CityEntity()
		{
			Id = 648,
					Name = "Seabra",
					Active = false,
				},
				new CityEntity()
		{
			Id = 649,
					Name = "Sebastião Laranjeiras",
					Active = false,
				},
				new CityEntity()
		{
			Id = 650,
					Name = "Senhor do Bonfim",
					Active = false,
				},
				new CityEntity()
		{
			Id = 651,
					Name = "Sento Sé",
					Active = false,
				},
				new CityEntity()
		{
			Id = 652,
					Name = "Serra do Ramalho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 653,
					Name = "Serra Dourada",
					Active = false,
				},
				new CityEntity()
		{
			Id = 654,
					Name = "Serra Preta",
					Active = false,
				},
				new CityEntity()
		{
			Id = 655,
					Name = "Serrinha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 656,
					Name = "Serrolândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 657,
					Name = "Simões Filho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 658,
					Name = "Sítio do Mato",
					Active = false,
				},
				new CityEntity()
		{
			Id = 659,
					Name = "Sítio do Quinto",
					Active = false,
				},
				new CityEntity()
		{
			Id = 660,
					Name = "Sobradinho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 661,
					Name = "Souto Soares",
					Active = false,
				},
				new CityEntity()
		{
			Id = 662,
					Name = "Tabocas do Brejo Velho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 663,
					Name = "Tanhaçu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 664,
					Name = "Tanque Novo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 665,
					Name = "Tanquinho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 666,
					Name = "Taperoá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 667,
					Name = "Tapiramutá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 668,
					Name = "Teixeira de Freitas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 669,
					Name = "Teodoro Sampaio",
					Active = false,
				},
				new CityEntity()
		{
			Id = 670,
					Name = "Teofilândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 671,
					Name = "Teolândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 672,
					Name = "Terra Nova",
					Active = false,
				},
				new CityEntity()
		{
			Id = 673,
					Name = "Tremedal",
					Active = false,
				},
				new CityEntity()
		{
			Id = 674,
					Name = "Tucano",
					Active = false,
				},
				new CityEntity()
		{
			Id = 675,
					Name = "Uauá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 676,
					Name = "Ubaíra",
					Active = false,
				},
				new CityEntity()
		{
			Id = 677,
					Name = "Ubaitaba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 678,
					Name = "Ubatã",
					Active = false,
				},
				new CityEntity()
		{
			Id = 679,
					Name = "Uibaí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 680,
					Name = "Umburanas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 681,
					Name = "Una",
					Active = false,
				},
				new CityEntity()
		{
			Id = 682,
					Name = "Urandi",
					Active = false,
				},
				new CityEntity()
		{
			Id = 683,
					Name = "Uruçuca",
					Active = false,
				},
				new CityEntity()
		{
			Id = 684,
					Name = "Utinga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 685,
					Name = "Valença",
					Active = false,
				},
				new CityEntity()
		{
			Id = 686,
					Name = "Valente",
					Active = false,
				},
				new CityEntity()
		{
			Id = 687,
					Name = "Várzea da Roça",
					Active = false,
				},
				new CityEntity()
		{
			Id = 688,
					Name = "Várzea do Poço",
					Active = false,
				},
				new CityEntity()
		{
			Id = 689,
					Name = "Várzea Nova",
					Active = false,
				},
				new CityEntity()
		{
			Id = 690,
					Name = "Varzedo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 691,
					Name = "Vera Cruz",
					Active = false,
				},
				new CityEntity()
		{
			Id = 692,
					Name = "Vereda",
					Active = false,
				},
				new CityEntity()
		{
			Id = 693,
					Name = "Vitória da Conquista",
					Active = false,
				},
				new CityEntity()
		{
			Id = 694,
					Name = "Wagner",
					Active = false,
				},
				new CityEntity()
		{
			Id = 695,
					Name = "Wanderley",
					Active = false,
				},
				new CityEntity()
		{
			Id = 696,
					Name = "Wenceslau Guimarães",
					Active = false,
				},
				new CityEntity()
		{
			Id = 697,
					Name = "Xique-Xique",
					Active = false,
				},
				new CityEntity()
		{
			Id = 698,
					Name = "Abaiara",
					Active = false,
				},
				new CityEntity()
		{
			Id = 699,
					Name = "Acarape",
					Active = false,
				},
				new CityEntity()
		{
			Id = 700,
					Name = "Acaraú",
					Active = false,
				},
				new CityEntity()
		{
			Id = 701,
					Name = "Acopiara",
					Active = false,
				},
				new CityEntity()
		{
			Id = 702,
					Name = "Aiuaba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 703,
					Name = "Alcântaras",
					Active = false,
				},
				new CityEntity()
		{
			Id = 704,
					Name = "Altaneira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 705,
					Name = "Alto Santo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 706,
					Name = "Amontada",
					Active = false,
				},
				new CityEntity()
		{
			Id = 707,
					Name = "Antonina do Norte",
					Active = false,
				},
				new CityEntity()
		{
			Id = 708,
					Name = "Apuiarés",
					Active = false,
				},
				new CityEntity()
		{
			Id = 709,
					Name = "Aquiraz",
					Active = false,
				},
				new CityEntity()
		{
			Id = 710,
					Name = "Aracati",
					Active = false,
				},
				new CityEntity()
		{
			Id = 711,
					Name = "Aracoiaba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 712,
					Name = "Ararendá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 713,
					Name = "Araripe",
					Active = false,
				},
				new CityEntity()
		{
			Id = 714,
					Name = "Aratuba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 715,
					Name = "Arneiroz",
					Active = false,
				},
				new CityEntity()
		{
			Id = 716,
					Name = "Assaré",
					Active = false,
				},
				new CityEntity()
		{
			Id = 717,
					Name = "Aurora",
					Active = false,
				},
				new CityEntity()
		{
			Id = 718,
					Name = "Baixio",
					Active = false,
				},
				new CityEntity()
		{
			Id = 719,
					Name = "Banabuiú",
					Active = false,
				},
				new CityEntity()
		{
			Id = 720,
					Name = "Barbalha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 721,
					Name = "Barreira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 722,
					Name = "Barro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 723,
					Name = "Barroquinha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 724,
					Name = "Baturité",
					Active = false,
				},
				new CityEntity()
		{
			Id = 725,
					Name = "Beberibe",
					Active = false,
				},
				new CityEntity()
		{
			Id = 726,
					Name = "Bela Cruz",
					Active = false,
				},
				new CityEntity()
		{
			Id = 727,
					Name = "Boa Viagem",
					Active = false,
				},
				new CityEntity()
		{
			Id = 728,
					Name = "Brejo Santo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 729,
					Name = "Camocim",
					Active = false,
				},
				new CityEntity()
		{
			Id = 730,
					Name = "Campos Sales",
					Active = false,
				},
				new CityEntity()
		{
			Id = 731,
					Name = "Canindé",
					Active = false,
				},
				new CityEntity()
		{
			Id = 732,
					Name = "Capistrano",
					Active = false,
				},
				new CityEntity()
		{
			Id = 733,
					Name = "Caridade",
					Active = false,
				},
				new CityEntity()
		{
			Id = 734,
					Name = "Cariré",
					Active = false,
				},
				new CityEntity()
		{
			Id = 735,
					Name = "Caririaçu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 736,
					Name = "Cariús",
					Active = false,
				},
				new CityEntity()
		{
			Id = 737,
					Name = "Carnaubal",
					Active = false,
				},
				new CityEntity()
		{
			Id = 738,
					Name = "Cascavel",
					Active = false,
				},
				new CityEntity()
		{
			Id = 739,
					Name = "Catarina",
					Active = false,
				},
				new CityEntity()
		{
			Id = 740,
					Name = "Catunda",
					Active = false,
				},
				new CityEntity()
		{
			Id = 741,
					Name = "Caucaia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 742,
					Name = "Cedro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 743,
					Name = "Chaval",
					Active = false,
				},
				new CityEntity()
		{
			Id = 744,
					Name = "Choró",
					Active = false,
				},
				new CityEntity()
		{
			Id = 745,
					Name = "Chorozinho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 746,
					Name = "Coreaú",
					Active = false,
				},
				new CityEntity()
		{
			Id = 747,
					Name = "Crateús",
					Active = false,
				},
				new CityEntity()
		{
			Id = 748,
					Name = "Crato",
					Active = false,
				},
				new CityEntity()
		{
			Id = 749,
					Name = "Croatá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 750,
					Name = "Cruz",
					Active = false,
				},
				new CityEntity()
		{
			Id = 751,
					Name = "Deputado Irapuan Pinheiro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 752,
					Name = "Ererê",
					Active = false,
				},
				new CityEntity()
		{
			Id = 753,
					Name = "Eusébio",
					Active = false,
				},
				new CityEntity()
		{
			Id = 754,
					Name = "Farias Brito",
					Active = false,
				},
				new CityEntity()
		{
			Id = 755,
					Name = "Forquilha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 756,
					Name = "Fortaleza",
					Active = false,
				},
				new CityEntity()
		{
			Id = 757,
					Name = "Fortim",
					Active = false,
				},
				new CityEntity()
		{
			Id = 758,
					Name = "Frecheirinha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 759,
					Name = "General Sampaio",
					Active = false,
				},
				new CityEntity()
		{
			Id = 760,
					Name = "Graça",
					Active = false,
				},
				new CityEntity()
		{
			Id = 761,
					Name = "Granja",
					Active = false,
				},
				new CityEntity()
		{
			Id = 762,
					Name = "Granjeiro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 763,
					Name = "Groaíras",
					Active = false,
				},
				new CityEntity()
		{
			Id = 764,
					Name = "Guaiúba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 765,
					Name = "Guaraciaba do Norte",
					Active = false,
				},
				new CityEntity()
		{
			Id = 766,
					Name = "Guaramiranga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 767,
					Name = "Hidrolândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 768,
					Name = "Horizonte",
					Active = false,
				},
				new CityEntity()
		{
			Id = 769,
					Name = "Ibaretama",
					Active = false,
				},
				new CityEntity()
		{
			Id = 770,
					Name = "Ibiapina",
					Active = false,
				},
				new CityEntity()
		{
			Id = 771,
					Name = "Ibicuitinga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 772,
					Name = "Icapuí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 773,
					Name = "Icó",
					Active = false,
				},
				new CityEntity()
		{
			Id = 774,
					Name = "Iguatu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 775,
					Name = "Independência",
					Active = false,
				},
				new CityEntity()
		{
			Id = 776,
					Name = "Ipaporanga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 777,
					Name = "Ipaumirim",
					Active = false,
				},
				new CityEntity()
		{
			Id = 778,
					Name = "Ipu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 779,
					Name = "Ipueiras",
					Active = false,
				},
				new CityEntity()
		{
			Id = 780,
					Name = "Iracema",
					Active = false,
				},
				new CityEntity()
		{
			Id = 781,
					Name = "Irauçuba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 782,
					Name = "Itaiçaba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 783,
					Name = "Itaitinga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 784,
					Name = "Itapagé",
					Active = false,
				},
				new CityEntity()
		{
			Id = 785,
					Name = "Itapipoca",
					Active = false,
				},
				new CityEntity()
		{
			Id = 786,
					Name = "Itapiúna",
					Active = false,
				},
				new CityEntity()
		{
			Id = 787,
					Name = "Itarema",
					Active = false,
				},
				new CityEntity()
		{
			Id = 788,
					Name = "Itatira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 789,
					Name = "Jaguaretama",
					Active = false,
				},
				new CityEntity()
		{
			Id = 790,
					Name = "Jaguaribara",
					Active = false,
				},
				new CityEntity()
		{
			Id = 791,
					Name = "Jaguaribe",
					Active = false,
				},
				new CityEntity()
		{
			Id = 792,
					Name = "Jaguaruana",
					Active = false,
				},
				new CityEntity()
		{
			Id = 793,
					Name = "Jardim",
					Active = false,
				},
				new CityEntity()
		{
			Id = 794,
					Name = "Jati",
					Active = false,
				},
				new CityEntity()
		{
			Id = 795,
					Name = "Jijoca de Jericoacoara",
					Active = false,
				},
				new CityEntity()
		{
			Id = 796,
					Name = "Juazeiro do Norte",
					Active = false,
				},
				new CityEntity()
		{
			Id = 797,
					Name = "Jucás",
					Active = false,
				},
				new CityEntity()
		{
			Id = 798,
					Name = "Lavras da Mangabeira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 799,
					Name = "Limoeiro do Norte",
					Active = false,
				},
				new CityEntity()
		{
			Id = 800,
					Name = "Madalena",
					Active = false,
				},
				new CityEntity()
		{
			Id = 801,
					Name = "Maracanaú",
					Active = false,
				},
				new CityEntity()
		{
			Id = 802,
					Name = "Maranguape",
					Active = false,
				},
				new CityEntity()
		{
			Id = 803,
					Name = "Marco",
					Active = false,
				},
				new CityEntity()
		{
			Id = 804,
					Name = "Martinópole",
					Active = false,
				},
				new CityEntity()
		{
			Id = 805,
					Name = "Massapê",
					Active = false,
				},
				new CityEntity()
		{
			Id = 806,
					Name = "Mauriti",
					Active = false,
				},
				new CityEntity()
		{
			Id = 807,
					Name = "Meruoca",
					Active = false,
				},
				new CityEntity()
		{
			Id = 808,
					Name = "Milagres",
					Active = false,
				},
				new CityEntity()
		{
			Id = 809,
					Name = "Milhã",
					Active = false,
				},
				new CityEntity()
		{
			Id = 810,
					Name = "Miraíma",
					Active = false,
				},
				new CityEntity()
		{
			Id = 811,
					Name = "Missão Velha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 812,
					Name = "Mombaça",
					Active = false,
				},
				new CityEntity()
		{
			Id = 813,
					Name = "Monsenhor Tabosa",
					Active = false,
				},
				new CityEntity()
		{
			Id = 814,
					Name = "Morada Nova",
					Active = false,
				},
				new CityEntity()
		{
			Id = 815,
					Name = "Moraújo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 816,
					Name = "Morrinhos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 817,
					Name = "Mucambo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 818,
					Name = "Mulungu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 819,
					Name = "Nova Olinda",
					Active = false,
				},
				new CityEntity()
		{
			Id = 820,
					Name = "Nova Russas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 821,
					Name = "Novo Oriente",
					Active = false,
				},
				new CityEntity()
		{
			Id = 822,
					Name = "Ocara",
					Active = false,
				},
				new CityEntity()
		{
			Id = 823,
					Name = "Orós",
					Active = false,
				},
				new CityEntity()
		{
			Id = 824,
					Name = "Pacajus",
					Active = false,
				},
				new CityEntity()
		{
			Id = 825,
					Name = "Pacatuba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 826,
					Name = "Pacoti",
					Active = false,
				},
				new CityEntity()
		{
			Id = 827,
					Name = "Pacujá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 828,
					Name = "Palhano",
					Active = false,
				},
				new CityEntity()
		{
			Id = 829,
					Name = "Palmácia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 830,
					Name = "Paracuru",
					Active = false,
				},
				new CityEntity()
		{
			Id = 831,
					Name = "Paraipaba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 832,
					Name = "Parambu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 833,
					Name = "Paramoti",
					Active = false,
				},
				new CityEntity()
		{
			Id = 834,
					Name = "Pedra Branca",
					Active = false,
				},
				new CityEntity()
		{
			Id = 835,
					Name = "Penaforte",
					Active = false,
				},
				new CityEntity()
		{
			Id = 836,
					Name = "Pentecoste",
					Active = false,
				},
				new CityEntity()
		{
			Id = 837,
					Name = "Pereiro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 838,
					Name = "Pindoretama",
					Active = false,
				},
				new CityEntity()
		{
			Id = 839,
					Name = "Piquet Carneiro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 840,
					Name = "Pires Ferreira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 841,
					Name = "Poranga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 842,
					Name = "Porteiras",
					Active = false,
				},
				new CityEntity()
		{
			Id = 843,
					Name = "Potengi",
					Active = false,
				},
				new CityEntity()
		{
			Id = 844,
					Name = "Potiretama",
					Active = false,
				},
				new CityEntity()
		{
			Id = 845,
					Name = "Quiterianópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 846,
					Name = "Quixadá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 847,
					Name = "Quixelô",
					Active = false,
				},
				new CityEntity()
		{
			Id = 848,
					Name = "Quixeramobim",
					Active = false,
				},
				new CityEntity()
		{
			Id = 849,
					Name = "Quixeré",
					Active = false,
				},
				new CityEntity()
		{
			Id = 850,
					Name = "Redenção",
					Active = false,
				},
				new CityEntity()
		{
			Id = 851,
					Name = "Reriutaba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 852,
					Name = "Russas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 853,
					Name = "Saboeiro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 854,
					Name = "Salitre",
					Active = false,
				},
				new CityEntity()
		{
			Id = 855,
					Name = "Santa Quitéria",
					Active = false,
				},
				new CityEntity()
		{
			Id = 856,
					Name = "Santana do Acaraú",
					Active = false,
				},
				new CityEntity()
		{
			Id = 857,
					Name = "Santana do Cariri",
					Active = false,
				},
				new CityEntity()
		{
			Id = 858,
					Name = "São Benedito",
					Active = false,
				},
				new CityEntity()
		{
			Id = 859,
					Name = "São Gonçalo do Amarante",
					Active = false,
				},
				new CityEntity()
		{
			Id = 860,
					Name = "São João do Jaguaribe",
					Active = false,
				},
				new CityEntity()
		{
			Id = 861,
					Name = "São Luís do Curu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 862,
					Name = "Senador Pompeu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 863,
					Name = "Senador Sá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 864,
					Name = "Sobral",
					Active = false,
				},
				new CityEntity()
		{
			Id = 865,
					Name = "Solonópole",
					Active = false,
				},
				new CityEntity()
		{
			Id = 866,
					Name = "Tabuleiro do Norte",
					Active = false,
				},
				new CityEntity()
		{
			Id = 867,
					Name = "Tamboril",
					Active = false,
				},
				new CityEntity()
		{
			Id = 868,
					Name = "Tarrafas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 869,
					Name = "Tauá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 870,
					Name = "Tejuçuoca",
					Active = false,
				},
				new CityEntity()
		{
			Id = 871,
					Name = "Tianguá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 872,
					Name = "Trairi",
					Active = false,
				},
				new CityEntity()
		{
			Id = 873,
					Name = "Tururu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 874,
					Name = "Ubajara",
					Active = false,
				},
				new CityEntity()
		{
			Id = 875,
					Name = "Umari",
					Active = false,
				},
				new CityEntity()
		{
			Id = 876,
					Name = "Umirim",
					Active = false,
				},
				new CityEntity()
		{
			Id = 877,
					Name = "Uruburetama",
					Active = false,
				},
				new CityEntity()
		{
			Id = 878,
					Name = "Uruoca",
					Active = false,
				},
				new CityEntity()
		{
			Id = 879,
					Name = "Varjota",
					Active = false,
				},
				new CityEntity()
		{
			Id = 880,
					Name = "Várzea Alegre",
					Active = false,
				},
				new CityEntity()
		{
			Id = 881,
					Name = "Viçosa do Ceará",
					Active = false,
				},
				new CityEntity()
		{
			Id = 882,
					Name = "Brasília",
					Active = false,
				},
				new CityEntity()
		{
			Id = 883,
					Name = "Abadia de Goiás",
					Active = false,
				},
				new CityEntity()
		{
			Id = 884,
					Name = "Abadiânia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 885,
					Name = "Acreúna",
					Active = false,
				},
				new CityEntity()
		{
			Id = 886,
					Name = "Adelândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 887,
					Name = "Água Fria de Goiás",
					Active = false,
				},
				new CityEntity()
		{
			Id = 888,
					Name = "Água Limpa",
					Active = false,
				},
				new CityEntity()
		{
			Id = 889,
					Name = "Águas Lindas de Goiás",
					Active = false,
				},
				new CityEntity()
		{
			Id = 890,
					Name = "Alexânia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 891,
					Name = "Aloândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 892,
					Name = "Alto Horizonte",
					Active = false,
				},
				new CityEntity()
		{
			Id = 893,
					Name = "Alto Paraíso de Goiás",
					Active = false,
				},
				new CityEntity()
		{
			Id = 894,
					Name = "Alvorada do Norte",
					Active = false,
				},
				new CityEntity()
		{
			Id = 895,
					Name = "Amaralina",
					Active = false,
				},
				new CityEntity()
		{
			Id = 896,
					Name = "Americano do Brasil",
					Active = false,
				},
				new CityEntity()
		{
			Id = 897,
					Name = "Amorinópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 898,
					Name = "Anápolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 899,
					Name = "Anhanguera",
					Active = false,
				},
				new CityEntity()
		{
			Id = 900,
					Name = "Anicuns",
					Active = false,
				},
				new CityEntity()
		{
			Id = 901,
					Name = "Aparecida de Goiânia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 902,
					Name = "Aparecida do Rio Doce",
					Active = false,
				},
				new CityEntity()
		{
			Id = 903,
					Name = "Aporé",
					Active = false,
				},
				new CityEntity()
		{
			Id = 904,
					Name = "Araçu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 905,
					Name = "Aragarças",
					Active = false,
				},
				new CityEntity()
		{
			Id = 906,
					Name = "Aragoiânia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 907,
					Name = "Araguapaz",
					Active = false,
				},
				new CityEntity()
		{
			Id = 908,
					Name = "Arenópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 909,
					Name = "Aruanã",
					Active = false,
				},
				new CityEntity()
		{
			Id = 910,
					Name = "Aurilândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 911,
					Name = "Avelinópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 912,
					Name = "Baliza",
					Active = false,
				},
				new CityEntity()
		{
			Id = 913,
					Name = "Barro Alto",
					Active = false,
				},
				new CityEntity()
		{
			Id = 914,
					Name = "Bela Vista de Goiás",
					Active = false,
				},
				new CityEntity()
		{
			Id = 915,
					Name = "Bom Jardim de Goiás",
					Active = false,
				},
				new CityEntity()
		{
			Id = 916,
					Name = "Bom Jesus de Goiás",
					Active = false,
				},
				new CityEntity()
		{
			Id = 917,
					Name = "Bonfinópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 918,
					Name = "Bonópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 919,
					Name = "Brazabrantes",
					Active = false,
				},
				new CityEntity()
		{
			Id = 920,
					Name = "Britânia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 921,
					Name = "Buriti Alegre",
					Active = false,
				},
				new CityEntity()
		{
			Id = 922,
					Name = "Buriti de Goiás",
					Active = false,
				},
				new CityEntity()
		{
			Id = 923,
					Name = "Buritinópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 924,
					Name = "Cabeceiras",
					Active = false,
				},
				new CityEntity()
		{
			Id = 925,
					Name = "Cachoeira Alta",
					Active = false,
				},
				new CityEntity()
		{
			Id = 926,
					Name = "Cachoeira de Goiás",
					Active = false,
				},
				new CityEntity()
		{
			Id = 927,
					Name = "Cachoeira Dourada",
					Active = false,
				},
				new CityEntity()
		{
			Id = 928,
					Name = "Caçu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 929,
					Name = "Caiapônia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 930,
					Name = "Caldas Novas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 931,
					Name = "Caldazinha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 932,
					Name = "Campestre de Goiás",
					Active = false,
				},
				new CityEntity()
		{
			Id = 933,
					Name = "Campinaçu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 934,
					Name = "Campinorte",
					Active = false,
				},
				new CityEntity()
		{
			Id = 935,
					Name = "Campo Alegre de Goiás",
					Active = false,
				},
				new CityEntity()
		{
			Id = 936,
					Name = "Campo Limpo de Goiás",
					Active = false,
				},
				new CityEntity()
		{
			Id = 937,
					Name = "Campos Belos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 938,
					Name = "Campos Verdes",
					Active = false,
				},
				new CityEntity()
		{
			Id = 939,
					Name = "Carmo do Rio Verde",
					Active = false,
				},
				new CityEntity()
		{
			Id = 940,
					Name = "Castelândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 941,
					Name = "Catalão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 942,
					Name = "Caturaí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 943,
					Name = "Cavalcante",
					Active = false,
				},
				new CityEntity()
		{
			Id = 944,
					Name = "Ceres",
					Active = false,
				},
				new CityEntity()
		{
			Id = 945,
					Name = "Cezarina",
					Active = false,
				},
				new CityEntity()
		{
			Id = 946,
					Name = "Chapadão do Céu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 947,
					Name = "Cidade Ocidental",
					Active = false,
				},
				new CityEntity()
		{
			Id = 948,
					Name = "Cocalzinho de Goiás",
					Active = false,
				},
				new CityEntity()
		{
			Id = 949,
					Name = "Colinas do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 950,
					Name = "Córrego do Ouro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 951,
					Name = "Corumbá de Goiás",
					Active = false,
				},
				new CityEntity()
		{
			Id = 952,
					Name = "Corumbaíba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 953,
					Name = "Cristalina",
					Active = false,
				},
				new CityEntity()
		{
			Id = 954,
					Name = "Cristianópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 955,
					Name = "Crixás",
					Active = false,
				},
				new CityEntity()
		{
			Id = 956,
					Name = "Cromínia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 957,
					Name = "Cumari",
					Active = false,
				},
				new CityEntity()
		{
			Id = 958,
					Name = "Damianópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 959,
					Name = "Damolândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 960,
					Name = "Davinópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 961,
					Name = "Diorama",
					Active = false,
				},
				new CityEntity()
		{
			Id = 962,
					Name = "Divinópolis de Goiás",
					Active = false,
				},
				new CityEntity()
		{
			Id = 963,
					Name = "Doverlândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 964,
					Name = "Edealina",
					Active = false,
				},
				new CityEntity()
		{
			Id = 965,
					Name = "Edéia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 966,
					Name = "Estrela do Norte",
					Active = false,
				},
				new CityEntity()
		{
			Id = 967,
					Name = "Faina",
					Active = false,
				},
				new CityEntity()
		{
			Id = 968,
					Name = "Fazenda Nova",
					Active = false,
				},
				new CityEntity()
		{
			Id = 969,
					Name = "Firminópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 970,
					Name = "Flores de Goiás",
					Active = false,
				},
				new CityEntity()
		{
			Id = 971,
					Name = "Formosa",
					Active = false,
				},
				new CityEntity()
		{
			Id = 972,
					Name = "Formoso",
					Active = false,
				},
				new CityEntity()
		{
			Id = 973,
					Name = "Gameleira de Goiás",
					Active = false,
				},
				new CityEntity()
		{
			Id = 974,
					Name = "Goianápolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 975,
					Name = "Goiandira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 976,
					Name = "Goianésia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 977,
					Name = "Goiânia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 978,
					Name = "Goianira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 979,
					Name = "Goiás",
					Active = false,
				},
				new CityEntity()
		{
			Id = 980,
					Name = "Goiatuba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 981,
					Name = "Gouvelândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 982,
					Name = "Guapó",
					Active = false,
				},
				new CityEntity()
		{
			Id = 983,
					Name = "Guaraíta",
					Active = false,
				},
				new CityEntity()
		{
			Id = 984,
					Name = "Guarani de Goiás",
					Active = false,
				},
				new CityEntity()
		{
			Id = 985,
					Name = "Guarinos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 986,
					Name = "Heitoraí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 987,
					Name = "Hidrolândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 988,
					Name = "Hidrolina",
					Active = false,
				},
				new CityEntity()
		{
			Id = 989,
					Name = "Iaciara",
					Active = false,
				},
				new CityEntity()
		{
			Id = 990,
					Name = "Inaciolândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 991,
					Name = "Indiara",
					Active = false,
				},
				new CityEntity()
		{
			Id = 992,
					Name = "Inhumas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 993,
					Name = "Ipameri",
					Active = false,
				},
				new CityEntity()
		{
			Id = 994,
					Name = "Ipiranga de Goiás",
					Active = false,
				},
				new CityEntity()
		{
			Id = 995,
					Name = "Iporá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 996,
					Name = "Israelândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 997,
					Name = "Itaberaí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 998,
					Name = "Itaguari",
					Active = false,
				},
				new CityEntity()
		{
			Id = 999,
					Name = "Itaguaru",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1000,
					Name = "Itajá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1001,
					Name = "Itapaci",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1002,
					Name = "Itapirapuã",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1003,
					Name = "Itapuranga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1004,
					Name = "Itarumã",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1005,
					Name = "Itauçu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1006,
					Name = "Itumbiara",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1007,
					Name = "Ivolândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1008,
					Name = "Jandaia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1009,
					Name = "Jaraguá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1010,
					Name = "Jataí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1011,
					Name = "Jaupaci",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1012,
					Name = "Jesúpolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1013,
					Name = "Joviânia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1014,
					Name = "Jussara",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1015,
					Name = "Lagoa Santa",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1016,
					Name = "Leopoldo de Bulhões",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1017,
					Name = "Luziânia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1018,
					Name = "Mairipotaba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1019,
					Name = "Mambaí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1020,
					Name = "Mara Rosa",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1021,
					Name = "Marzagão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1022,
					Name = "Matrinchã",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1023,
					Name = "Maurilândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1024,
					Name = "Mimoso de Goiás",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1025,
					Name = "Minaçu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1026,
					Name = "Mineiros",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1027,
					Name = "Moiporá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1028,
					Name = "Monte Alegre de Goiás",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1029,
					Name = "Montes Claros de Goiás",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1030,
					Name = "Montividiu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1031,
					Name = "Montividiu do Norte",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1032,
					Name = "Morrinhos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1033,
					Name = "Morro Agudo de Goiás",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1034,
					Name = "Mossâmedes",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1035,
					Name = "Mozarlândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1036,
					Name = "Mundo Novo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1037,
					Name = "Mutunópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1038,
					Name = "Nazário",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1039,
					Name = "Nerópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1040,
					Name = "Niquelândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1041,
					Name = "Nova América",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1042,
					Name = "Nova Aurora",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1043,
					Name = "Nova Crixás",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1044,
					Name = "Nova Glória",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1045,
					Name = "Nova Iguaçu de Goiás",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1046,
					Name = "Nova Roma",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1047,
					Name = "Nova Veneza",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1048,
					Name = "Novo Brasil",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1049,
					Name = "Novo Gama",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1050,
					Name = "Novo Planalto",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1051,
					Name = "Orizona",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1052,
					Name = "Ouro Verde de Goiás",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1053,
					Name = "Ouvidor",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1054,
					Name = "Padre Bernardo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1055,
					Name = "Palestina de Goiás",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1056,
					Name = "Palmeiras de Goiás",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1057,
					Name = "Palmelo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1058,
					Name = "Palminópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1059,
					Name = "Panamá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1060,
					Name = "Paranaiguara",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1061,
					Name = "Paraúna",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1062,
					Name = "Perolândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1063,
					Name = "Petrolina de Goiás",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1064,
					Name = "Pilar de Goiás",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1065,
					Name = "Piracanjuba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1066,
					Name = "Piranhas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1067,
					Name = "Pirenópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1068,
					Name = "Pires do Rio",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1069,
					Name = "Planaltina",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1070,
					Name = "Pontalina",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1071,
					Name = "Porangatu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1072,
					Name = "Porteirão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1073,
					Name = "Portelândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1074,
					Name = "Posse",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1075,
					Name = "Professor Jamil",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1076,
					Name = "Quirinópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1077,
					Name = "Rialma",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1078,
					Name = "Rianápolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1079,
					Name = "Rio Quente",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1080,
					Name = "Rio Verde",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1081,
					Name = "Rubiataba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1082,
					Name = "Sanclerlândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1083,
					Name = "Santa Bárbara de Goiás",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1084,
					Name = "Santa Cruz de Goiás",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1085,
					Name = "Santa Fé de Goiás",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1086,
					Name = "Santa Helena de Goiás",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1087,
					Name = "Santa Isabel",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1088,
					Name = "Santa Rita do Araguaia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1089,
					Name = "Santa Rita do Novo Destino",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1090,
					Name = "Santa Rosa de Goiás",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1091,
					Name = "Santa Tereza de Goiás",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1092,
					Name = "Santa Terezinha de Goiás",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1093,
					Name = "Santo Antônio da Barra",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1094,
					Name = "Santo Antônio de Goiás",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1095,
					Name = "Santo Antônio do Descoberto",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1096,
					Name = "São Domingos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1097,
					Name = "São Francisco de Goiás",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1098,
					Name = "São João d`Aliança",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1099,
					Name = "São João da Paraúna",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1100,
					Name = "São Luís de Montes Belos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1101,
					Name = "São Luíz do Norte",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1102,
					Name = "São Miguel do Araguaia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1103,
					Name = "São Miguel do Passa Quatro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1104,
					Name = "São Patrício",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1105,
					Name = "São Simão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1106,
					Name = "Senador Canedo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1107,
					Name = "Serranópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1108,
					Name = "Silvânia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1109,
					Name = "Simolândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1110,
					Name = "Sítio d`Abadia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1111,
					Name = "Taquaral de Goiás",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1112,
					Name = "Teresina de Goiás",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1113,
					Name = "Terezópolis de Goiás",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1114,
					Name = "Três Ranchos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1115,
					Name = "Trindade",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1116,
					Name = "Trombas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1117,
					Name = "Turvânia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1118,
					Name = "Turvelândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1119,
					Name = "Uirapuru",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1120,
					Name = "Uruaçu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1121,
					Name = "Uruana",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1122,
					Name = "Urutaí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1123,
					Name = "Valparaíso de Goiás",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1124,
					Name = "Varjão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1125,
					Name = "Vianópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1126,
					Name = "Vicentinópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1127,
					Name = "Vila Boa",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1128,
					Name = "Vila Propício",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1129,
					Name = "Açailândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1130,
					Name = "Afonso Cunha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1131,
					Name = "Água Doce do Maranhão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1132,
					Name = "Alcântara",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1133,
					Name = "Aldeias Altas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1134,
					Name = "Altamira do Maranhão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1135,
					Name = "Alto Alegre do Maranhão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1136,
					Name = "Alto Alegre do Pindaré",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1137,
					Name = "Alto Parnaíba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1138,
					Name = "Amapá do Maranhão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1139,
					Name = "Amarante do Maranhão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1140,
					Name = "Anajatuba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1141,
					Name = "Anapurus",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1142,
					Name = "Apicum-Açu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1143,
					Name = "Araguanã",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1144,
					Name = "Araioses",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1145,
					Name = "Arame",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1146,
					Name = "Arari",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1147,
					Name = "Axixá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1148,
					Name = "Bacabal",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1149,
					Name = "Bacabeira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1150,
					Name = "Bacuri",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1151,
					Name = "Bacurituba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1152,
					Name = "Balsas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1153,
					Name = "Barão de Grajaú",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1154,
					Name = "Barra do Corda",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1155,
					Name = "Barreirinhas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1156,
					Name = "Bela Vista do Maranhão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1157,
					Name = "Belágua",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1158,
					Name = "Benedito Leite",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1159,
					Name = "Bequimão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1160,
					Name = "Bernardo do Mearim",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1161,
					Name = "Boa Vista do Gurupi",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1162,
					Name = "Bom Jardim",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1163,
					Name = "Bom Jesus das Selvas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1164,
					Name = "Bom Lugar",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1165,
					Name = "Brejo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1166,
					Name = "Brejo de Areia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1167,
					Name = "Buriti",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1168,
					Name = "Buriti Bravo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1169,
					Name = "Buriticupu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1170,
					Name = "Buritirana",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1171,
					Name = "Cachoeira Grande",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1172,
					Name = "Cajapió",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1173,
					Name = "Cajari",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1174,
					Name = "Campestre do Maranhão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1175,
					Name = "Cândido Mendes",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1176,
					Name = "Cantanhede",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1177,
					Name = "Capinzal do Norte",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1178,
					Name = "Carolina",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1179,
					Name = "Carutapera",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1180,
					Name = "Caxias",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1181,
					Name = "Cedral",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1182,
					Name = "Central do Maranhão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1183,
					Name = "Centro do Guilherme",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1184,
					Name = "Centro Novo do Maranhão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1185,
					Name = "Chapadinha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1186,
					Name = "Cidelândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1187,
					Name = "Codó",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1188,
					Name = "Coelho Neto",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1189,
					Name = "Colinas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1190,
					Name = "Conceição do Lago-Açu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1191,
					Name = "Coroatá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1192,
					Name = "Cururupu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1193,
					Name = "Davinópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1194,
					Name = "Dom Pedro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1195,
					Name = "Duque Bacelar",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1196,
					Name = "Esperantinópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1197,
					Name = "Estreito",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1198,
					Name = "Feira Nova do Maranhão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1199,
					Name = "Fernando Falcão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1200,
					Name = "Formosa da Serra Negra",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1201,
					Name = "Fortaleza dos Nogueiras",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1202,
					Name = "Fortuna",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1203,
					Name = "Godofredo Viana",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1204,
					Name = "Gonçalves Dias",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1205,
					Name = "Governador Archer",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1206,
					Name = "Governador Edison Lobão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1207,
					Name = "Governador Eugênio Barros",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1208,
					Name = "Governador Luiz Rocha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1209,
					Name = "Governador Newton Bello",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1210,
					Name = "Governador Nunes Freire",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1211,
					Name = "Graça Aranha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1212,
					Name = "Grajaú",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1213,
					Name = "Guimarães",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1214,
					Name = "Humberto de Campos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1215,
					Name = "Icatu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1216,
					Name = "Igarapé do Meio",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1217,
					Name = "Igarapé Grande",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1218,
					Name = "Imperatriz",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1219,
					Name = "Itaipava do Grajaú",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1220,
					Name = "Itapecuru Mirim",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1221,
					Name = "Itinga do Maranhão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1222,
					Name = "Jatobá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1223,
					Name = "Jenipapo dos Vieiras",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1224,
					Name = "João Lisboa",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1225,
					Name = "Joselândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1226,
					Name = "Junco do Maranhão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1227,
					Name = "Lago da Pedra",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1228,
					Name = "Lago do Junco",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1229,
					Name = "Lago dos Rodrigues",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1230,
					Name = "Lago Verde",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1231,
					Name = "Lagoa do Mato",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1232,
					Name = "Lagoa Grande do Maranhão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1233,
					Name = "Lajeado Novo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1234,
					Name = "Lima Campos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1235,
					Name = "Loreto",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1236,
					Name = "Luís Domingues",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1237,
					Name = "Magalhães de Almeida",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1238,
					Name = "Maracaçumé",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1239,
					Name = "Marajá do Sena",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1240,
					Name = "Maranhãozinho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1241,
					Name = "Mata Roma",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1242,
					Name = "Matinha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1243,
					Name = "Matões",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1244,
					Name = "Matões do Norte",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1245,
					Name = "Milagres do Maranhão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1246,
					Name = "Mirador",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1247,
					Name = "Miranda do Norte",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1248,
					Name = "Mirinzal",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1249,
					Name = "Monção",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1250,
					Name = "Montes Altos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1251,
					Name = "Morros",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1252,
					Name = "Nina Rodrigues",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1253,
					Name = "Nova Colinas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1254,
					Name = "Nova Iorque",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1255,
					Name = "Nova Olinda do Maranhão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1256,
					Name = "Olho d`Água das Cunhãs",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1257,
					Name = "Olinda Nova do Maranhão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1258,
					Name = "Paço do Lumiar",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1259,
					Name = "Palmeirândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1260,
					Name = "Paraibano",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1261,
					Name = "Parnarama",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1262,
					Name = "Passagem Franca",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1263,
					Name = "Pastos Bons",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1264,
					Name = "Paulino Neves",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1265,
					Name = "Paulo Ramos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1266,
					Name = "Pedreiras",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1267,
					Name = "Pedro do Rosário",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1268,
					Name = "Penalva",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1269,
					Name = "Peri Mirim",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1270,
					Name = "Peritoró",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1271,
					Name = "Pindaré-Mirim",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1272,
					Name = "Pinheiro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1273,
					Name = "Pio XII",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1274,
					Name = "Pirapemas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1275,
					Name = "Poção de Pedras",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1276,
					Name = "Porto Franco",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1277,
					Name = "Porto Rico do Maranhão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1278,
					Name = "Presidente Dutra",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1279,
					Name = "Presidente Juscelino",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1280,
					Name = "Presidente Médici",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1281,
					Name = "Presidente Sarney",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1282,
					Name = "Presidente Vargas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1283,
					Name = "Primeira Cruz",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1284,
					Name = "Raposa",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1285,
					Name = "Riachão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1286,
					Name = "Ribamar Fiquene",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1287,
					Name = "Rosário",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1288,
					Name = "Sambaíba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1289,
					Name = "Santa Filomena do Maranhão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1290,
					Name = "Santa Helena",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1291,
					Name = "Santa Inês",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1292,
					Name = "Santa Luzia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1293,
					Name = "Santa Luzia do Paruá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1294,
					Name = "Santa Quitéria do Maranhão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1295,
					Name = "Santa Rita",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1296,
					Name = "Santana do Maranhão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1297,
					Name = "Santo Amaro do Maranhão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1298,
					Name = "Santo Antônio dos Lopes",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1299,
					Name = "São Benedito do Rio Preto",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1300,
					Name = "São Bento",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1301,
					Name = "São Bernardo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1302,
					Name = "São Domingos do Azeitão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1303,
					Name = "São Domingos do Maranhão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1304,
					Name = "São Félix de Balsas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1305,
					Name = "São Francisco do Brejão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1306,
					Name = "São Francisco do Maranhão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1307,
					Name = "São João Batista",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1308,
					Name = "São João do Carú",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1309,
					Name = "São João do Paraíso",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1310,
					Name = "São João do Soter",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1311,
					Name = "São João dos Patos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1312,
					Name = "São José de Ribamar",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1313,
					Name = "São José dos Basílios",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1314,
					Name = "São Luís",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1315,
					Name = "São Luís Gonzaga do Maranhão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1316,
					Name = "São Mateus do Maranhão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1317,
					Name = "São Pedro da Água Branca",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1318,
					Name = "São Pedro dos Crentes",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1319,
					Name = "São Raimundo das Mangabeiras",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1320,
					Name = "São Raimundo do Doca Bezerra",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1321,
					Name = "São Roberto",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1322,
					Name = "São Vicente Ferrer",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1323,
					Name = "Satubinha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1324,
					Name = "Senador Alexandre Costa",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1325,
					Name = "Senador La Rocque",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1326,
					Name = "Serrano do Maranhão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1327,
					Name = "Sítio Novo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1328,
					Name = "Sucupira do Norte",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1329,
					Name = "Sucupira do Riachão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1330,
					Name = "Tasso Fragoso",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1331,
					Name = "Timbiras",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1332,
					Name = "Timon",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1333,
					Name = "Trizidela do Vale",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1334,
					Name = "Tufilândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1335,
					Name = "Tuntum",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1336,
					Name = "Turiaçu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1337,
					Name = "Turilândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1338,
					Name = "Tutóia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1339,
					Name = "Urbano Santos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1340,
					Name = "Vargem Grande",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1341,
					Name = "Viana",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1342,
					Name = "Vila Nova dos Martírios",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1343,
					Name = "Vitória do Mearim",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1344,
					Name = "Vitorino Freire",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1345,
					Name = "Zé Doca",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1346,
					Name = "Acorizal",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1347,
					Name = "Água Boa",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1348,
					Name = "Alta Floresta",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1349,
					Name = "Alto Araguaia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1350,
					Name = "Alto Boa Vista",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1351,
					Name = "Alto Garças",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1352,
					Name = "Alto Paraguai",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1353,
					Name = "Alto Taquari",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1354,
					Name = "Apiacás",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1355,
					Name = "Araguaiana",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1356,
					Name = "Araguainha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1357,
					Name = "Araputanga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1358,
					Name = "Arenápolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1359,
					Name = "Aripuanã",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1360,
					Name = "Barão de Melgaço",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1361,
					Name = "Barra do Bugres",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1362,
					Name = "Barra do Garças",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1363,
					Name = "Bom Jesus do Araguaia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1364,
					Name = "Brasnorte",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1365,
					Name = "Cáceres",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1366,
					Name = "Campinápolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1367,
					Name = "Campo Novo do Parecis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1368,
					Name = "Campo Verde",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1369,
					Name = "Campos de Júlio",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1370,
					Name = "Canabrava do Norte",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1371,
					Name = "Canarana",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1372,
					Name = "Carlinda",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1373,
					Name = "Castanheira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1374,
					Name = "Chapada dos Guimarães",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1375,
					Name = "Cláudia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1376,
					Name = "Cocalinho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1377,
					Name = "Colíder",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1378,
					Name = "Colniza",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1379,
					Name = "Comodoro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1380,
					Name = "Confresa",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1381,
					Name = "Conquista d`Oeste",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1382,
					Name = "Cotriguaçu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1383,
					Name = "Cuiabá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1384,
					Name = "Curvelândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1386,
					Name = "Denise",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1387,
					Name = "Diamantino",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1388,
					Name = "Dom Aquino",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1389,
					Name = "Feliz Natal",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1390,
					Name = "Figueirópolis d`Oeste",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1391,
					Name = "Gaúcha do Norte",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1392,
					Name = "General Carneiro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1393,
					Name = "Glória d`Oeste",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1394,
					Name = "Guarantã do Norte",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1395,
					Name = "Guiratinga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1396,
					Name = "Indiavaí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1397,
					Name = "Ipiranga do Norte",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1398,
					Name = "Itanhangá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1399,
					Name = "Itaúba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1400,
					Name = "Itiquira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1401,
					Name = "Jaciara",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1402,
					Name = "Jangada",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1403,
					Name = "Jauru",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1404,
					Name = "Juara",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1405,
					Name = "Juína",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1406,
					Name = "Juruena",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1407,
					Name = "Juscimeira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1408,
					Name = "Lambari d`Oeste",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1409,
					Name = "Lucas do Rio Verde",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1410,
					Name = "Luciára",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1411,
					Name = "Marcelândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1412,
					Name = "Matupá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1413,
					Name = "Mirassol d`Oeste",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1414,
					Name = "Nobres",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1415,
					Name = "Nortelândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1416,
					Name = "Nossa Senhora do Livramento",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1417,
					Name = "Nova Bandeirantes",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1418,
					Name = "Nova Brasilândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1419,
					Name = "Nova Canaã do Norte",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1420,
					Name = "Nova Guarita",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1421,
					Name = "Nova Lacerda",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1422,
					Name = "Nova Marilândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1423,
					Name = "Nova Maringá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1424,
					Name = "Nova Monte verde",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1425,
					Name = "Nova Mutum",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1426,
					Name = "Nova Olímpia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1427,
					Name = "Nova Santa Helena",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1428,
					Name = "Nova Ubiratã",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1429,
					Name = "Nova Xavantina",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1430,
					Name = "Novo Horizonte do Norte",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1431,
					Name = "Novo Mundo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1432,
					Name = "Novo Santo Antônio",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1433,
					Name = "Novo São Joaquim",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1434,
					Name = "Paranaíta",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1435,
					Name = "Paranatinga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1436,
					Name = "Pedra Preta",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1437,
					Name = "Peixoto de Azevedo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1438,
					Name = "Planalto da Serra",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1439,
					Name = "Poconé",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1440,
					Name = "Pontal do Araguaia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1441,
					Name = "Ponte Branca",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1442,
					Name = "Pontes e Lacerda",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1443,
					Name = "Porto Alegre do Norte",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1444,
					Name = "Porto dos Gaúchos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1445,
					Name = "Porto Esperidião",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1446,
					Name = "Porto Estrela",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1447,
					Name = "Poxoréo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1448,
					Name = "Primavera do Leste",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1449,
					Name = "Querência",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1450,
					Name = "Reserva do Cabaçal",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1451,
					Name = "Ribeirão Cascalheira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1452,
					Name = "Ribeirãozinho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1453,
					Name = "Rio Branco",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1454,
					Name = "Rondolândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1455,
					Name = "Rondonópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1456,
					Name = "Rosário Oeste",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1457,
					Name = "Salto do Céu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1458,
					Name = "Santa Carmem",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1459,
					Name = "Santa Cruz do Xingu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1460,
					Name = "Santa Rita do Trivelato",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1461,
					Name = "Santa Terezinha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1462,
					Name = "Santo Afonso",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1463,
					Name = "Santo Antônio do Leste",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1464,
					Name = "Santo Antônio do Leverger",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1465,
					Name = "São Félix do Araguaia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1466,
					Name = "São José do Povo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1467,
					Name = "São José do Rio Claro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1468,
					Name = "São José do Xingu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1469,
					Name = "São José dos Quatro Marcos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1470,
					Name = "São Pedro da Cipa",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1471,
					Name = "Sapezal",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1472,
					Name = "Serra Nova Dourada",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1473,
					Name = "Sinop",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1474,
					Name = "Sorriso",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1475,
					Name = "Tabaporã",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1476,
					Name = "Tangará da Serra",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1477,
					Name = "Tapurah",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1478,
					Name = "Terra Nova do Norte",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1479,
					Name = "Tesouro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1480,
					Name = "Torixoréu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1481,
					Name = "União do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1482,
					Name = "Vale de São Domingos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1483,
					Name = "Várzea Grande",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1484,
					Name = "Vera",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1485,
					Name = "Vila Bela da Santíssima Trindade",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1486,
					Name = "Vila Rica",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1487,
					Name = "Água Clara",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1488,
					Name = "Alcinópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1489,
					Name = "Amambaí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1490,
					Name = "Anastácio",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1491,
					Name = "Anaurilândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1492,
					Name = "Angélica",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1493,
					Name = "Antônio João",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1494,
					Name = "Aparecida do Taboado",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1495,
					Name = "Aquidauana",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1496,
					Name = "Aral Moreira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1497,
					Name = "Bandeirantes",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1498,
					Name = "Bataguassu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1499,
					Name = "Bataiporã",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1500,
					Name = "Bela Vista",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1501,
					Name = "Bodoquena",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1502,
					Name = "Bonito",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1503,
					Name = "Brasilândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1504,
					Name = "Caarapó",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1505,
					Name = "Camapuã",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1506,
					Name = "Campo Grande",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1507,
					Name = "Caracol",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1508,
					Name = "Cassilândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1509,
					Name = "Chapadão do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1510,
					Name = "Corguinho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1511,
					Name = "Coronel Sapucaia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1512,
					Name = "Corumbá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1513,
					Name = "Costa Rica",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1514,
					Name = "Coxim",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1515,
					Name = "Deodápolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1516,
					Name = "Dois Irmãos do Buriti",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1517,
					Name = "Douradina",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1518,
					Name = "Dourados",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1519,
					Name = "Eldorado",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1520,
					Name = "Fátima do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1521,
					Name = "Figueirão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1522,
					Name = "Glória de Dourados",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1523,
					Name = "Guia Lopes da Laguna",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1524,
					Name = "Iguatemi",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1525,
					Name = "Inocência",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1526,
					Name = "Itaporã",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1527,
					Name = "Itaquiraí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1528,
					Name = "Ivinhema",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1529,
					Name = "Japorã",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1530,
					Name = "Jaraguari",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1531,
					Name = "Jardim",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1532,
					Name = "Jateí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1533,
					Name = "Juti",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1534,
					Name = "Ladário",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1535,
					Name = "Laguna Carapã",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1536,
					Name = "Maracaju",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1537,
					Name = "Miranda",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1538,
					Name = "Mundo Novo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1539,
					Name = "Naviraí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1540,
					Name = "Nioaque",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1541,
					Name = "Nova Alvorada do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1542,
					Name = "Nova Andradina",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1543,
					Name = "Novo Horizonte do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1544,
					Name = "Paranaíba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1545,
					Name = "Paranhos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1546,
					Name = "Pedro Gomes",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1547,
					Name = "Ponta Porã",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1548,
					Name = "Porto Murtinho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1549,
					Name = "Ribas do Rio Pardo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1550,
					Name = "Rio Brilhante",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1551,
					Name = "Rio Negro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1552,
					Name = "Rio Verde de Mato Grosso",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1553,
					Name = "Rochedo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1554,
					Name = "Santa Rita do Pardo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1555,
					Name = "São Gabriel do Oeste",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1556,
					Name = "Selvíria",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1557,
					Name = "Sete Quedas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1558,
					Name = "Sidrolândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1559,
					Name = "Sonora",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1560,
					Name = "Tacuru",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1561,
					Name = "Taquarussu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1562,
					Name = "Terenos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1563,
					Name = "Três Lagoas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1564,
					Name = "Vicentina",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1565,
					Name = "Abadia dos Dourados",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1566,
					Name = "Abaeté",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1567,
					Name = "Abre Campo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1568,
					Name = "Acaiaca",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1569,
					Name = "Açucena",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1570,
					Name = "Água Boa",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1571,
					Name = "Água Comprida",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1572,
					Name = "Aguanil",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1573,
					Name = "Águas Formosas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1574,
					Name = "Águas Vermelhas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1575,
					Name = "Aimorés",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1576,
					Name = "Aiuruoca",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1577,
					Name = "Alagoa",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1578,
					Name = "Albertina",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1579,
					Name = "Além Paraíba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1580,
					Name = "Alfenas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1581,
					Name = "Alfredo Vasconcelos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1582,
					Name = "Almenara",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1583,
					Name = "Alpercata",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1584,
					Name = "Alpinópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1585,
					Name = "Alterosa",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1586,
					Name = "Alto Caparaó",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1587,
					Name = "Alto Jequitibá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1588,
					Name = "Alto Rio Doce",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1589,
					Name = "Alvarenga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1590,
					Name = "Alvinópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1591,
					Name = "Alvorada de Minas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1592,
					Name = "Amparo do Serra",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1593,
					Name = "Andradas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1594,
					Name = "Andrelândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1595,
					Name = "Angelândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1596,
					Name = "Antônio Carlos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1597,
					Name = "Antônio Dias",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1598,
					Name = "Antônio Prado de Minas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1599,
					Name = "Araçaí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1600,
					Name = "Aracitaba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1601,
					Name = "Araçuaí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1602,
					Name = "Araguari",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1603,
					Name = "Arantina",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1604,
					Name = "Araponga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1605,
					Name = "Araporã",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1606,
					Name = "Arapuá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1607,
					Name = "Araújos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1608,
					Name = "Araxá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1609,
					Name = "Arceburgo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1610,
					Name = "Arcos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1611,
					Name = "Areado",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1612,
					Name = "Argirita",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1613,
					Name = "Aricanduva",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1614,
					Name = "Arinos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1615,
					Name = "Astolfo Dutra",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1616,
					Name = "Ataléia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1617,
					Name = "Augusto de Lima",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1618,
					Name = "Baependi",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1619,
					Name = "Baldim",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1620,
					Name = "Bambuí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1621,
					Name = "Bandeira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1622,
					Name = "Bandeira do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1623,
					Name = "Barão de Cocais",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1624,
					Name = "Barão de Monte Alto",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1625,
					Name = "Barbacena",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1626,
					Name = "Barra Longa",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1627,
					Name = "Barroso",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1628,
					Name = "Bela Vista de Minas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1629,
					Name = "Belmiro Braga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1630,
					Name = "Belo Horizonte",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1631,
					Name = "Belo Oriente",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1632,
					Name = "Belo Vale",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1633,
					Name = "Berilo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1634,
					Name = "Berizal",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1635,
					Name = "Bertópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1636,
					Name = "Betim",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1637,
					Name = "Bias Fortes",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1638,
					Name = "Bicas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1639,
					Name = "Biquinhas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1640,
					Name = "Boa Esperança",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1641,
					Name = "Bocaina de Minas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1642,
					Name = "Bocaiúva",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1643,
					Name = "Bom Despacho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1644,
					Name = "Bom Jardim de Minas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1645,
					Name = "Bom Jesus da Penha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1646,
					Name = "Bom Jesus do Amparo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1647,
					Name = "Bom Jesus do Galho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1648,
					Name = "Bom Repouso",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1649,
					Name = "Bom Sucesso",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1650,
					Name = "Bonfim",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1651,
					Name = "Bonfinópolis de Minas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1652,
					Name = "Bonito de Minas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1653,
					Name = "Borda da Mata",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1654,
					Name = "Botelhos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1655,
					Name = "Botumirim",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1656,
					Name = "Brás Pires",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1657,
					Name = "Brasilândia de Minas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1658,
					Name = "Brasília de Minas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1659,
					Name = "Brasópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1660,
					Name = "Braúnas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1661,
					Name = "Brumadinho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1662,
					Name = "Bueno Brandão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1663,
					Name = "Buenópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1664,
					Name = "Bugre",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1665,
					Name = "Buritis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1666,
					Name = "Buritizeiro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1667,
					Name = "Cabeceira Grande",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1668,
					Name = "Cabo Verde",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1669,
					Name = "Cachoeira da Prata",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1670,
					Name = "Cachoeira de Minas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1671,
					Name = "Cachoeira de Pajeú",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1672,
					Name = "Cachoeira Dourada",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1673,
					Name = "Caetanópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1674,
					Name = "Caeté",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1675,
					Name = "Caiana",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1676,
					Name = "Cajuri",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1677,
					Name = "Caldas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1678,
					Name = "Camacho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1679,
					Name = "Camanducaia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1680,
					Name = "Cambuí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1681,
					Name = "Cambuquira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1682,
					Name = "Campanário",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1683,
					Name = "Campanha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1684,
					Name = "Campestre",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1685,
					Name = "Campina Verde",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1686,
					Name = "Campo Azul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1687,
					Name = "Campo Belo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1688,
					Name = "Campo do Meio",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1689,
					Name = "Campo Florido",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1690,
					Name = "Campos Altos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1691,
					Name = "Campos Gerais",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1692,
					Name = "Cana Verde",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1693,
					Name = "Canaã",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1694,
					Name = "Canápolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1695,
					Name = "Candeias",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1696,
					Name = "Cantagalo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1697,
					Name = "Caparaó",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1698,
					Name = "Capela Nova",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1699,
					Name = "Capelinha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1700,
					Name = "Capetinga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1701,
					Name = "Capim Branco",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1702,
					Name = "Capinópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1703,
					Name = "Capitão Andrade",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1704,
					Name = "Capitão Enéas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1705,
					Name = "Capitólio",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1706,
					Name = "Caputira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1707,
					Name = "Caraí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1708,
					Name = "Caranaíba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1709,
					Name = "Carandaí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1710,
					Name = "Carangola",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1711,
					Name = "Caratinga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1712,
					Name = "Carbonita",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1713,
					Name = "Careaçu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1714,
					Name = "Carlos Chagas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1715,
					Name = "Carmésia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1716,
					Name = "Carmo da Cachoeira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1717,
					Name = "Carmo da Mata",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1718,
					Name = "Carmo de Minas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1719,
					Name = "Carmo do Cajuru",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1720,
					Name = "Carmo do Paranaíba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1721,
					Name = "Carmo do Rio Claro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1722,
					Name = "Carmópolis de Minas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1723,
					Name = "Carneirinho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1724,
					Name = "Carrancas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1725,
					Name = "Carvalhópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1726,
					Name = "Carvalhos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1727,
					Name = "Casa Grande",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1728,
					Name = "Cascalho Rico",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1729,
					Name = "Cássia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1730,
					Name = "Cataguases",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1731,
					Name = "Catas Altas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1732,
					Name = "Catas Altas da Noruega",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1733,
					Name = "Catuji",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1734,
					Name = "Catuti",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1735,
					Name = "Caxambu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1736,
					Name = "Cedro do Abaeté",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1737,
					Name = "Central de Minas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1738,
					Name = "Centralina",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1739,
					Name = "Chácara",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1740,
					Name = "Chalé",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1741,
					Name = "Chapada do Norte",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1742,
					Name = "Chapada Gaúcha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1743,
					Name = "Chiador",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1744,
					Name = "Cipotânea",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1745,
					Name = "Claraval",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1746,
					Name = "Claro dos Poções",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1747,
					Name = "Cláudio",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1748,
					Name = "Coimbra",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1749,
					Name = "Coluna",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1750,
					Name = "Comendador Gomes",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1751,
					Name = "Comercinho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1752,
					Name = "Conceição da Aparecida",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1753,
					Name = "Conceição da Barra de Minas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1754,
					Name = "Conceição das Alagoas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1755,
					Name = "Conceição das Pedras",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1756,
					Name = "Conceição de Ipanema",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1757,
					Name = "Conceição do Mato Dentro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1758,
					Name = "Conceição do Pará",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1759,
					Name = "Conceição do Rio Verde",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1760,
					Name = "Conceição dos Ouros",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1761,
					Name = "Cônego Marinho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1762,
					Name = "Confins",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1763,
					Name = "Congonhal",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1764,
					Name = "Congonhas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1765,
					Name = "Congonhas do Norte",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1766,
					Name = "Conquista",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1767,
					Name = "Conselheiro Lafaiete",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1768,
					Name = "Conselheiro Pena",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1769,
					Name = "Consolação",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1770,
					Name = "Contagem",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1771,
					Name = "Coqueiral",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1772,
					Name = "Coração de Jesus",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1773,
					Name = "Cordisburgo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1774,
					Name = "Cordislândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1775,
					Name = "Corinto",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1776,
					Name = "Coroaci",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1777,
					Name = "Coromandel",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1778,
					Name = "Coronel Fabriciano",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1779,
					Name = "Coronel Murta",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1780,
					Name = "Coronel Pacheco",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1781,
					Name = "Coronel Xavier Chaves",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1782,
					Name = "Córrego Danta",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1783,
					Name = "Córrego do Bom Jesus",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1784,
					Name = "Córrego Fundo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1785,
					Name = "Córrego Novo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1786,
					Name = "Couto de Magalhães de Minas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1787,
					Name = "Crisólita",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1788,
					Name = "Cristais",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1789,
					Name = "Cristália",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1790,
					Name = "Cristiano Otoni",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1791,
					Name = "Cristina",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1792,
					Name = "Crucilândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1793,
					Name = "Cruzeiro da Fortaleza",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1794,
					Name = "Cruzília",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1795,
					Name = "Cuparaque",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1796,
					Name = "Curral de Dentro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1797,
					Name = "Curvelo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1798,
					Name = "Datas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1799,
					Name = "Delfim Moreira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1800,
					Name = "Delfinópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1801,
					Name = "Delta",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1802,
					Name = "Descoberto",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1803,
					Name = "Desterro de Entre Rios",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1804,
					Name = "Desterro do Melo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1805,
					Name = "Diamantina",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1806,
					Name = "Diogo de Vasconcelos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1807,
					Name = "Dionísio",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1808,
					Name = "Divinésia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1809,
					Name = "Divino",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1810,
					Name = "Divino das Laranjeiras",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1811,
					Name = "Divinolândia de Minas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1812,
					Name = "Divinópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1813,
					Name = "Divisa Alegre",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1814,
					Name = "Divisa Nova",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1815,
					Name = "Divisópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1816,
					Name = "Dom Bosco",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1817,
					Name = "Dom Cavati",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1818,
					Name = "Dom Joaquim",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1819,
					Name = "Dom Silvério",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1820,
					Name = "Dom Viçoso",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1821,
					Name = "Dona Eusébia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1822,
					Name = "Dores de Campos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1823,
					Name = "Dores de Guanhães",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1824,
					Name = "Dores do Indaiá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1825,
					Name = "Dores do Turvo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1826,
					Name = "Doresópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1827,
					Name = "Douradoquara",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1828,
					Name = "Durandé",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1829,
					Name = "Elói Mendes",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1830,
					Name = "Engenheiro Caldas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1831,
					Name = "Engenheiro Navarro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1832,
					Name = "Entre Folhas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1833,
					Name = "Entre Rios de Minas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1834,
					Name = "Ervália",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1835,
					Name = "Esmeraldas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1836,
					Name = "Espera Feliz",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1837,
					Name = "Espinosa",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1838,
					Name = "Espírito Santo do Dourado",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1839,
					Name = "Estiva",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1840,
					Name = "Estrela Dalva",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1841,
					Name = "Estrela do Indaiá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1842,
					Name = "Estrela do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1843,
					Name = "Eugenópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1844,
					Name = "Ewbank da Câmara",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1845,
					Name = "Extrema",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1846,
					Name = "Fama",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1847,
					Name = "Faria Lemos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1848,
					Name = "Felício dos Santos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1849,
					Name = "Felisburgo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1850,
					Name = "Felixlândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1851,
					Name = "Fernandes Tourinho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1852,
					Name = "Ferros",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1853,
					Name = "Fervedouro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1854,
					Name = "Florestal",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1855,
					Name = "Formiga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1856,
					Name = "Formoso",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1857,
					Name = "Fortaleza de Minas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1858,
					Name = "Fortuna de Minas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1859,
					Name = "Francisco Badaró",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1860,
					Name = "Francisco Dumont",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1861,
					Name = "Francisco Sá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1862,
					Name = "Franciscópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1863,
					Name = "Frei Gaspar",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1864,
					Name = "Frei Inocêncio",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1865,
					Name = "Frei Lagonegro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1866,
					Name = "Fronteira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1867,
					Name = "Fronteira dos Vales",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1868,
					Name = "Fruta de Leite",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1869,
					Name = "Frutal",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1870,
					Name = "Funilândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1871,
					Name = "Galiléia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1872,
					Name = "Gameleiras",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1873,
					Name = "Glaucilândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1874,
					Name = "Goiabeira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1875,
					Name = "Goianá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1876,
					Name = "Gonçalves",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1877,
					Name = "Gonzaga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1878,
					Name = "Gouveia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1879,
					Name = "Governador Valadares",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1880,
					Name = "Grão Mogol",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1881,
					Name = "Grupiara",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1882,
					Name = "Guanhães",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1883,
					Name = "Guapé",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1884,
					Name = "Guaraciaba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1885,
					Name = "Guaraciama",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1886,
					Name = "Guaranésia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1887,
					Name = "Guarani",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1888,
					Name = "Guarará",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1889,
					Name = "Guarda-Mor",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1890,
					Name = "Guaxupé",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1891,
					Name = "Guidoval",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1892,
					Name = "Guimarânia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1893,
					Name = "Guiricema",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1894,
					Name = "Gurinhatã",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1895,
					Name = "Heliodora",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1896,
					Name = "Iapu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1897,
					Name = "Ibertioga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1898,
					Name = "Ibiá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1899,
					Name = "Ibiaí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1900,
					Name = "Ibiracatu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1901,
					Name = "Ibiraci",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1902,
					Name = "Ibirité",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1903,
					Name = "Ibitiúra de Minas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1904,
					Name = "Ibituruna",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1905,
					Name = "Icaraí de Minas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1906,
					Name = "Igarapé",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1907,
					Name = "Igaratinga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1908,
					Name = "Iguatama",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1909,
					Name = "Ijaci",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1910,
					Name = "Ilicínea",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1911,
					Name = "Imbé de Minas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1912,
					Name = "Inconfidentes",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1913,
					Name = "Indaiabira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1914,
					Name = "Indianópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1915,
					Name = "Ingaí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1916,
					Name = "Inhapim",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1917,
					Name = "Inhaúma",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1918,
					Name = "Inimutaba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1919,
					Name = "Ipaba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1920,
					Name = "Ipanema",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1921,
					Name = "Ipatinga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1922,
					Name = "Ipiaçu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1923,
					Name = "Ipuiúna",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1924,
					Name = "Iraí de Minas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1925,
					Name = "Itabira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1926,
					Name = "Itabirinha de Mantena",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1927,
					Name = "Itabirito",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1928,
					Name = "Itacambira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1929,
					Name = "Itacarambi",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1930,
					Name = "Itaguara",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1931,
					Name = "Itaipé",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1932,
					Name = "Itajubá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1933,
					Name = "Itamarandiba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1934,
					Name = "Itamarati de Minas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1935,
					Name = "Itambacuri",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1936,
					Name = "Itambé do Mato Dentro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1937,
					Name = "Itamogi",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1938,
					Name = "Itamonte",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1939,
					Name = "Itanhandu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1940,
					Name = "Itanhomi",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1941,
					Name = "Itaobim",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1942,
					Name = "Itapagipe",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1943,
					Name = "Itapecerica",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1944,
					Name = "Itapeva",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1945,
					Name = "Itatiaiuçu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1946,
					Name = "Itaú de Minas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1947,
					Name = "Itaúna",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1948,
					Name = "Itaverava",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1949,
					Name = "Itinga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1950,
					Name = "Itueta",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1951,
					Name = "Ituiutaba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1952,
					Name = "Itumirim",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1953,
					Name = "Iturama",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1954,
					Name = "Itutinga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1955,
					Name = "Jaboticatubas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1956,
					Name = "Jacinto",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1957,
					Name = "Jacuí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1958,
					Name = "Jacutinga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1959,
					Name = "Jaguaraçu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1960,
					Name = "Jaíba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1961,
					Name = "Jampruca",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1962,
					Name = "Janaúba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1963,
					Name = "Januária",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1964,
					Name = "Japaraíba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1965,
					Name = "Japonvar",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1966,
					Name = "Jeceaba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1967,
					Name = "Jenipapo de Minas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1968,
					Name = "Jequeri",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1969,
					Name = "Jequitaí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1970,
					Name = "Jequitibá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1971,
					Name = "Jequitinhonha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1972,
					Name = "Jesuânia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1973,
					Name = "Joaíma",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1974,
					Name = "Joanésia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1975,
					Name = "João Monlevade",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1976,
					Name = "João Pinheiro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1977,
					Name = "Joaquim Felício",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1978,
					Name = "Jordânia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1979,
					Name = "José Gonçalves de Minas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1980,
					Name = "José Raydan",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1981,
					Name = "Josenópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1982,
					Name = "Juatuba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1983,
					Name = "Juiz de Fora",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1984,
					Name = "Juramento",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1985,
					Name = "Juruaia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1986,
					Name = "Juvenília",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1987,
					Name = "Ladainha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1988,
					Name = "Lagamar",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1989,
					Name = "Lagoa da Prata",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1990,
					Name = "Lagoa dos Patos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1991,
					Name = "Lagoa Dourada",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1992,
					Name = "Lagoa Formosa",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1993,
					Name = "Lagoa Grande",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1994,
					Name = "Lagoa Santa",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1995,
					Name = "Lajinha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1996,
					Name = "Lambari",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1997,
					Name = "Lamim",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1998,
					Name = "Laranjal",
					Active = false,
				},
				new CityEntity()
		{
			Id = 1999,
					Name = "Lassance",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2000,
					Name = "Lavras",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2001,
					Name = "Leandro Ferreira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2002,
					Name = "Leme do Prado",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2003,
					Name = "Leopoldina",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2004,
					Name = "Liberdade",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2005,
					Name = "Lima Duarte",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2006,
					Name = "Limeira do Oeste",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2007,
					Name = "Lontra",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2008,
					Name = "Luisburgo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2009,
					Name = "Luislândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2010,
					Name = "Luminárias",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2011,
					Name = "Luz",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2012,
					Name = "Machacalis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2013,
					Name = "Machado",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2014,
					Name = "Madre de Deus de Minas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2015,
					Name = "Malacacheta",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2016,
					Name = "Mamonas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2017,
					Name = "Manga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2018,
					Name = "Manhuaçu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2019,
					Name = "Manhumirim",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2020,
					Name = "Mantena",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2021,
					Name = "Mar de Espanha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2022,
					Name = "Maravilhas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2023,
					Name = "Maria da Fé",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2024,
					Name = "Mariana",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2025,
					Name = "Marilac",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2026,
					Name = "Mário Campos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2027,
					Name = "Maripá de Minas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2028,
					Name = "Marliéria",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2029,
					Name = "Marmelópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2030,
					Name = "Martinho Campos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2031,
					Name = "Martins Soares",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2032,
					Name = "Mata Verde",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2033,
					Name = "Materlândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2034,
					Name = "Mateus Leme",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2035,
					Name = "Mathias Lobato",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2036,
					Name = "Matias Barbosa",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2037,
					Name = "Matias Cardoso",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2038,
					Name = "Matipó",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2039,
					Name = "Mato Verde",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2040,
					Name = "Matozinhos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2041,
					Name = "Matutina",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2042,
					Name = "Medeiros",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2043,
					Name = "Medina",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2044,
					Name = "Mendes Pimentel",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2045,
					Name = "Mercês",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2046,
					Name = "Mesquita",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2047,
					Name = "Minas Novas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2048,
					Name = "Minduri",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2049,
					Name = "Mirabela",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2050,
					Name = "Miradouro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2051,
					Name = "Miraí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2052,
					Name = "Miravânia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2053,
					Name = "Moeda",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2054,
					Name = "Moema",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2055,
					Name = "Monjolos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2056,
					Name = "Monsenhor Paulo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2057,
					Name = "Montalvânia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2058,
					Name = "Monte Alegre de Minas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2059,
					Name = "Monte Azul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2060,
					Name = "Monte Belo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2061,
					Name = "Monte Carmelo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2062,
					Name = "Monte Formoso",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2063,
					Name = "Monte Santo de Minas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2064,
					Name = "Monte Sião",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2065,
					Name = "Montes Claros",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2066,
					Name = "Montezuma",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2067,
					Name = "Morada Nova de Minas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2068,
					Name = "Morro da Garça",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2069,
					Name = "Morro do Pilar",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2070,
					Name = "Munhoz",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2071,
					Name = "Muriaé",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2072,
					Name = "Mutum",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2073,
					Name = "Muzambinho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2074,
					Name = "Nacip Raydan",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2075,
					Name = "Nanuque",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2076,
					Name = "Naque",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2077,
					Name = "Natalândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2078,
					Name = "Natércia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2079,
					Name = "Nazareno",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2080,
					Name = "Nepomuceno",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2081,
					Name = "Ninheira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2082,
					Name = "Nova Belém",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2083,
					Name = "Nova Era",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2084,
					Name = "Nova Lima",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2085,
					Name = "Nova Módica",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2086,
					Name = "Nova Ponte",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2087,
					Name = "Nova Porteirinha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2088,
					Name = "Nova Resende",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2089,
					Name = "Nova Serrana",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2090,
					Name = "Nova União",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2091,
					Name = "Novo Cruzeiro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2092,
					Name = "Novo Oriente de Minas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2093,
					Name = "Novorizonte",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2094,
					Name = "Olaria",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2095,
					Name = "Olhos-d`Água",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2096,
					Name = "Olímpio Noronha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2097,
					Name = "Oliveira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2098,
					Name = "Oliveira Fortes",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2099,
					Name = "Onça de Pitangui",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2100,
					Name = "Oratórios",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2101,
					Name = "Orizânia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2102,
					Name = "Ouro Branco",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2103,
					Name = "Ouro Fino",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2104,
					Name = "Ouro Preto",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2105,
					Name = "Ouro Verde de Minas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2106,
					Name = "Padre Carvalho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2107,
					Name = "Padre Paraíso",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2108,
					Name = "Pai Pedro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2109,
					Name = "Paineiras",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2110,
					Name = "Pains",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2111,
					Name = "Paiva",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2112,
					Name = "Palma",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2113,
					Name = "Palmópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2114,
					Name = "Papagaios",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2115,
					Name = "Pará de Minas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2116,
					Name = "Paracatu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2117,
					Name = "Paraguaçu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2118,
					Name = "Paraisópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2119,
					Name = "Paraopeba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2120,
					Name = "Passa Quatro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2121,
					Name = "Passa Tempo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2122,
					Name = "Passabém",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2123,
					Name = "Passa-Vinte",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2124,
					Name = "Passos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2125,
					Name = "Patis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2126,
					Name = "Patos de Minas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2127,
					Name = "Patrocínio",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2128,
					Name = "Patrocínio do Muriaé",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2129,
					Name = "Paula Cândido",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2130,
					Name = "Paulistas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2131,
					Name = "Pavão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2132,
					Name = "Peçanha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2133,
					Name = "Pedra Azul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2134,
					Name = "Pedra Bonita",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2135,
					Name = "Pedra do Anta",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2136,
					Name = "Pedra do Indaiá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2137,
					Name = "Pedra Dourada",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2138,
					Name = "Pedralva",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2139,
					Name = "Pedras de Maria da Cruz",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2140,
					Name = "Pedrinópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2141,
					Name = "Pedro Leopoldo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2142,
					Name = "Pedro Teixeira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2143,
					Name = "Pequeri",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2144,
					Name = "Pequi",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2145,
					Name = "Perdigão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2146,
					Name = "Perdizes",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2147,
					Name = "Perdões",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2148,
					Name = "Periquito",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2149,
					Name = "Pescador",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2150,
					Name = "Piau",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2151,
					Name = "Piedade de Caratinga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2152,
					Name = "Piedade de Ponte Nova",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2153,
					Name = "Piedade do Rio Grande",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2154,
					Name = "Piedade dos Gerais",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2155,
					Name = "Pimenta",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2156,
					Name = "Pingo-d`Água",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2157,
					Name = "Pintópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2158,
					Name = "Piracema",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2159,
					Name = "Pirajuba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2160,
					Name = "Piranga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2161,
					Name = "Piranguçu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2162,
					Name = "Piranguinho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2163,
					Name = "Pirapetinga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2164,
					Name = "Pirapora",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2165,
					Name = "Piraúba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2166,
					Name = "Pitangui",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2167,
					Name = "Piumhi",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2168,
					Name = "Planura",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2169,
					Name = "Poço Fundo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2170,
					Name = "Poços de Caldas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2171,
					Name = "Pocrane",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2172,
					Name = "Pompéu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2173,
					Name = "Ponte Nova",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2174,
					Name = "Ponto Chique",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2175,
					Name = "Ponto dos Volantes",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2176,
					Name = "Porteirinha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2177,
					Name = "Porto Firme",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2178,
					Name = "Poté",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2179,
					Name = "Pouso Alegre",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2180,
					Name = "Pouso Alto",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2181,
					Name = "Prados",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2182,
					Name = "Prata",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2183,
					Name = "Pratápolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2184,
					Name = "Pratinha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2185,
					Name = "Presidente Bernardes",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2186,
					Name = "Presidente Juscelino",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2187,
					Name = "Presidente Kubitschek",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2188,
					Name = "Presidente Olegário",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2189,
					Name = "Prudente de Morais",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2190,
					Name = "Quartel Geral",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2191,
					Name = "Queluzito",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2192,
					Name = "Raposos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2193,
					Name = "Raul Soares",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2194,
					Name = "Recreio",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2195,
					Name = "Reduto",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2196,
					Name = "Resende Costa",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2197,
					Name = "Resplendor",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2198,
					Name = "Ressaquinha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2199,
					Name = "Riachinho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2200,
					Name = "Riacho dos Machados",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2201,
					Name = "Ribeirão das Neves",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2202,
					Name = "Ribeirão Vermelho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2203,
					Name = "Rio Acima",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2204,
					Name = "Rio Casca",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2205,
					Name = "Rio do Prado",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2206,
					Name = "Rio Doce",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2207,
					Name = "Rio Espera",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2208,
					Name = "Rio Manso",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2209,
					Name = "Rio Novo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2210,
					Name = "Rio Paranaíba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2211,
					Name = "Rio Pardo de Minas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2212,
					Name = "Rio Piracicaba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2213,
					Name = "Rio Pomba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2214,
					Name = "Rio Preto",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2215,
					Name = "Rio Vermelho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2216,
					Name = "Ritápolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2217,
					Name = "Rochedo de Minas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2218,
					Name = "Rodeiro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2219,
					Name = "Romaria",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2220,
					Name = "Rosário da Limeira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2221,
					Name = "Rubelita",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2222,
					Name = "Rubim",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2223,
					Name = "Sabará",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2224,
					Name = "Sabinópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2225,
					Name = "Sacramento",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2226,
					Name = "Salinas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2227,
					Name = "Salto da Divisa",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2228,
					Name = "Santa Bárbara",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2229,
					Name = "Santa Bárbara do Leste",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2230,
					Name = "Santa Bárbara do Monte Verde",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2231,
					Name = "Santa Bárbara do Tugúrio",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2232,
					Name = "Santa Cruz de Minas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2233,
					Name = "Santa Cruz de Salinas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2234,
					Name = "Santa Cruz do Escalvado",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2235,
					Name = "Santa Efigênia de Minas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2236,
					Name = "Santa Fé de Minas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2237,
					Name = "Santa Helena de Minas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2238,
					Name = "Santa Juliana",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2239,
					Name = "Santa Luzia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2240,
					Name = "Santa Margarida",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2241,
					Name = "Santa Maria de Itabira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2242,
					Name = "Santa Maria do Salto",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2243,
					Name = "Santa Maria do Suaçuí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2244,
					Name = "Santa Rita de Caldas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2245,
					Name = "Santa Rita de Ibitipoca",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2246,
					Name = "Santa Rita de Jacutinga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2247,
					Name = "Santa Rita de Minas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2248,
					Name = "Santa Rita do Itueto",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2249,
					Name = "Santa Rita do Sapucaí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2250,
					Name = "Santa Rosa da Serra",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2251,
					Name = "Santa Vitória",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2252,
					Name = "Santana da Vargem",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2253,
					Name = "Santana de Cataguases",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2254,
					Name = "Santana de Pirapama",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2255,
					Name = "Santana do Deserto",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2256,
					Name = "Santana do Garambéu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2257,
					Name = "Santana do Jacaré",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2258,
					Name = "Santana do Manhuaçu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2259,
					Name = "Santana do Paraíso",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2260,
					Name = "Santana do Riacho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2261,
					Name = "Santana dos Montes",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2262,
					Name = "Santo Antônio do Amparo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2263,
					Name = "Santo Antônio do Aventureiro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2264,
					Name = "Santo Antônio do Grama",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2265,
					Name = "Santo Antônio do Itambé",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2266,
					Name = "Santo Antônio do Jacinto",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2267,
					Name = "Santo Antônio do Monte",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2268,
					Name = "Santo Antônio do Retiro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2269,
					Name = "Santo Antônio do Rio Abaixo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2270,
					Name = "Santo Hipólito",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2271,
					Name = "Santos Dumont",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2272,
					Name = "São Bento Abade",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2273,
					Name = "São Brás do Suaçuí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2274,
					Name = "São Domingos das Dores",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2275,
					Name = "São Domingos do Prata",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2276,
					Name = "São Félix de Minas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2277,
					Name = "São Francisco",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2278,
					Name = "São Francisco de Paula",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2279,
					Name = "São Francisco de Sales",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2280,
					Name = "São Francisco do Glória",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2281,
					Name = "São Geraldo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2282,
					Name = "São Geraldo da Piedade",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2283,
					Name = "São Geraldo do Baixio",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2284,
					Name = "São Gonçalo do Abaeté",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2285,
					Name = "São Gonçalo do Pará",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2286,
					Name = "São Gonçalo do Rio Abaixo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2287,
					Name = "São Gonçalo do Rio Preto",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2288,
					Name = "São Gonçalo do Sapucaí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2289,
					Name = "São Gotardo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2290,
					Name = "São João Batista do Glória",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2291,
					Name = "São João da Lagoa",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2292,
					Name = "São João da Mata",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2293,
					Name = "São João da Ponte",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2294,
					Name = "São João das Missões",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2295,
					Name = "São João del Rei",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2296,
					Name = "São João do Manhuaçu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2297,
					Name = "São João do Manteninha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2298,
					Name = "São João do Oriente",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2299,
					Name = "São João do Pacuí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2300,
					Name = "São João do Paraíso",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2301,
					Name = "São João Evangelista",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2302,
					Name = "São João Nepomuceno",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2303,
					Name = "São Joaquim de Bicas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2304,
					Name = "São José da Barra",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2305,
					Name = "São José da Lapa",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2306,
					Name = "São José da Safira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2307,
					Name = "São José da Varginha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2308,
					Name = "São José do Alegre",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2309,
					Name = "São José do Divino",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2310,
					Name = "São José do Goiabal",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2311,
					Name = "São José do Jacuri",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2312,
					Name = "São José do Mantimento",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2313,
					Name = "São Lourenço",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2314,
					Name = "São Miguel do Anta",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2315,
					Name = "São Pedro da União",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2316,
					Name = "São Pedro do Suaçuí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2317,
					Name = "São Pedro dos Ferros",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2318,
					Name = "São Romão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2319,
					Name = "São Roque de Minas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2320,
					Name = "São Sebastião da Bela Vista",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2321,
					Name = "São Sebastião da Vargem Alegre",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2322,
					Name = "São Sebastião do Anta",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2323,
					Name = "São Sebastião do Maranhão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2324,
					Name = "São Sebastião do Oeste",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2325,
					Name = "São Sebastião do Paraíso",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2326,
					Name = "São Sebastião do Rio Preto",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2327,
					Name = "São Sebastião do Rio Verde",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2328,
					Name = "São Thomé das Letras",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2329,
					Name = "São Tiago",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2330,
					Name = "São Tomás de Aquino",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2331,
					Name = "São Vicente de Minas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2332,
					Name = "Sapucaí-Mirim",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2333,
					Name = "Sardoá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2334,
					Name = "Sarzedo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2335,
					Name = "Sem-Peixe",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2336,
					Name = "Senador Amaral",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2337,
					Name = "Senador Cortes",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2338,
					Name = "Senador Firmino",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2339,
					Name = "Senador José Bento",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2340,
					Name = "Senador Modestino Gonçalves",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2341,
					Name = "Senhora de Oliveira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2342,
					Name = "Senhora do Porto",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2343,
					Name = "Senhora dos Remédios",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2344,
					Name = "Sericita",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2345,
					Name = "Seritinga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2346,
					Name = "Serra Azul de Minas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2347,
					Name = "Serra da Saudade",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2348,
					Name = "Serra do Salitre",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2349,
					Name = "Serra dos Aimorés",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2350,
					Name = "Serrania",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2351,
					Name = "Serranópolis de Minas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2352,
					Name = "Serranos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2353,
					Name = "Serro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2354,
					Name = "Sete Lagoas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2355,
					Name = "Setubinha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2356,
					Name = "Silveirânia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2357,
					Name = "Silvianópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2358,
					Name = "Simão Pereira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2359,
					Name = "Simonésia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2360,
					Name = "Sobrália",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2361,
					Name = "Soledade de Minas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2362,
					Name = "Tabuleiro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2363,
					Name = "Taiobeiras",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2364,
					Name = "Taparuba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2365,
					Name = "Tapira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2366,
					Name = "Tapiraí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2367,
					Name = "Taquaraçu de Minas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2368,
					Name = "Tarumirim",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2369,
					Name = "Teixeiras",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2370,
					Name = "Teófilo Otoni",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2371,
					Name = "Timóteo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2372,
					Name = "Tiradentes",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2373,
					Name = "Tiros",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2374,
					Name = "Tocantins",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2375,
					Name = "Tocos do Moji",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2376,
					Name = "Toledo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2377,
					Name = "Tombos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2378,
					Name = "Três Corações",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2379,
					Name = "Três Marias",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2380,
					Name = "Três Pontas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2381,
					Name = "Tumiritinga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2382,
					Name = "Tupaciguara",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2383,
					Name = "Turmalina",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2384,
					Name = "Turvolândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2385,
					Name = "Ubá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2386,
					Name = "Ubaí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2387,
					Name = "Ubaporanga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2388,
					Name = "Uberaba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2389,
					Name = "Uberlândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2390,
					Name = "Umburatiba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2391,
					Name = "Unaí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2392,
					Name = "União de Minas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2393,
					Name = "Uruana de Minas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2394,
					Name = "Urucânia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2395,
					Name = "Urucuia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2396,
					Name = "Vargem Alegre",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2397,
					Name = "Vargem Bonita",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2398,
					Name = "Vargem Grande do Rio Pardo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2399,
					Name = "Varginha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2400,
					Name = "Varjão de Minas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2401,
					Name = "Várzea da Palma",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2402,
					Name = "Varzelândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2403,
					Name = "Vazante",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2404,
					Name = "Verdelândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2405,
					Name = "Veredinha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2406,
					Name = "Veríssimo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2407,
					Name = "Vermelho Novo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2408,
					Name = "Vespasiano",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2409,
					Name = "Viçosa",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2410,
					Name = "Vieiras",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2411,
					Name = "Virgem da Lapa",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2412,
					Name = "Virgínia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2413,
					Name = "Virginópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2414,
					Name = "Virgolândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2415,
					Name = "Visconde do Rio Branco",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2416,
					Name = "Volta Grande",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2417,
					Name = "Wenceslau Braz",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2418,
					Name = "Abaetetuba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2419,
					Name = "Abel Figueiredo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2420,
					Name = "Acará",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2421,
					Name = "Afuá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2422,
					Name = "Água Azul do Norte",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2423,
					Name = "Alenquer",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2424,
					Name = "Almeirim",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2425,
					Name = "Altamira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2426,
					Name = "Anajás",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2427,
					Name = "Ananindeua",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2428,
					Name = "Anapu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2429,
					Name = "Augusto Corrêa",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2430,
					Name = "Aurora do Pará",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2431,
					Name = "Aveiro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2432,
					Name = "Bagre",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2433,
					Name = "Baião",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2434,
					Name = "Bannach",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2435,
					Name = "Barcarena",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2436,
					Name = "Belém",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2437,
					Name = "Belterra",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2438,
					Name = "Benevides",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2439,
					Name = "Bom Jesus do Tocantins",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2440,
					Name = "Bonito",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2441,
					Name = "Bragança",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2442,
					Name = "Brasil Novo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2443,
					Name = "Brejo Grande do Araguaia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2444,
					Name = "Breu Branco",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2445,
					Name = "Breves",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2446,
					Name = "Bujaru",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2447,
					Name = "Cachoeira do Arari",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2448,
					Name = "Cachoeira do Piriá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2449,
					Name = "Cametá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2450,
					Name = "Canaã dos Carajás",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2451,
					Name = "Capanema",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2452,
					Name = "Capitão Poço",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2453,
					Name = "Castanhal",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2454,
					Name = "Chaves",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2455,
					Name = "Colares",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2456,
					Name = "Conceição do Araguaia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2457,
					Name = "Concórdia do Pará",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2458,
					Name = "Cumaru do Norte",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2459,
					Name = "Curionópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2460,
					Name = "Curralinho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2461,
					Name = "Curuá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2462,
					Name = "Curuçá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2463,
					Name = "Dom Eliseu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2464,
					Name = "Eldorado dos Carajás",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2465,
					Name = "Faro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2466,
					Name = "Floresta do Araguaia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2467,
					Name = "Garrafão do Norte",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2468,
					Name = "Goianésia do Pará",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2469,
					Name = "Gurupá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2470,
					Name = "Igarapé-Açu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2471,
					Name = "Igarapé-Miri",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2472,
					Name = "Inhangapi",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2473,
					Name = "Ipixuna do Pará",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2474,
					Name = "Irituia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2475,
					Name = "Itaituba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2476,
					Name = "Itupiranga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2477,
					Name = "Jacareacanga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2478,
					Name = "Jacundá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2479,
					Name = "Juruti",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2480,
					Name = "Limoeiro do Ajuru",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2481,
					Name = "Mãe do Rio",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2482,
					Name = "Magalhães Barata",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2483,
					Name = "Marabá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2484,
					Name = "Maracanã",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2485,
					Name = "Marapanim",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2486,
					Name = "Marituba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2487,
					Name = "Medicilândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2488,
					Name = "Melgaço",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2489,
					Name = "Mocajuba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2490,
					Name = "Moju",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2491,
					Name = "Monte Alegre",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2492,
					Name = "Muaná",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2493,
					Name = "Nova Esperança do Piriá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2494,
					Name = "Nova Ipixuna",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2495,
					Name = "Nova Timboteua",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2496,
					Name = "Novo Progresso",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2497,
					Name = "Novo Repartimento",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2498,
					Name = "Óbidos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2499,
					Name = "Oeiras do Pará",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2500,
					Name = "Oriximiná",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2501,
					Name = "Ourém",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2502,
					Name = "Ourilândia do Norte",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2503,
					Name = "Pacajá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2504,
					Name = "Palestina do Pará",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2505,
					Name = "Paragominas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2506,
					Name = "Parauapebas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2507,
					Name = "Pau d`Arco",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2508,
					Name = "Peixe-Boi",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2509,
					Name = "Piçarra",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2510,
					Name = "Placas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2511,
					Name = "Ponta de Pedras",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2512,
					Name = "Portel",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2513,
					Name = "Porto de Moz",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2514,
					Name = "Prainha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2515,
					Name = "Primavera",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2516,
					Name = "Quatipuru",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2517,
					Name = "Redenção",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2518,
					Name = "Rio Maria",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2519,
					Name = "Rondon do Pará",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2520,
					Name = "Rurópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2521,
					Name = "Salinópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2522,
					Name = "Salvaterra",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2523,
					Name = "Santa Bárbara do Pará",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2524,
					Name = "Santa Cruz do Arari",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2525,
					Name = "Santa Isabel do Pará",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2526,
					Name = "Santa Luzia do Pará",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2527,
					Name = "Santa Maria das Barreiras",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2528,
					Name = "Santa Maria do Pará",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2529,
					Name = "Santana do Araguaia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2530,
					Name = "Santarém",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2531,
					Name = "Santarém Novo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2532,
					Name = "Santo Antônio do Tauá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2533,
					Name = "São Caetano de Odivelas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2534,
					Name = "São Domingos do Araguaia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2535,
					Name = "São Domingos do Capim",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2536,
					Name = "São Félix do Xingu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2537,
					Name = "São Francisco do Pará",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2538,
					Name = "São Geraldo do Araguaia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2539,
					Name = "São João da Ponta",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2540,
					Name = "São João de Pirabas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2541,
					Name = "São João do Araguaia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2542,
					Name = "São Miguel do Guamá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2543,
					Name = "São Sebastião da Boa Vista",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2544,
					Name = "Sapucaia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2545,
					Name = "Senador José Porfírio",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2546,
					Name = "Soure",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2547,
					Name = "Tailândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2548,
					Name = "Terra Alta",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2549,
					Name = "Terra Santa",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2550,
					Name = "Tomé-Açu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2551,
					Name = "Tracuateua",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2552,
					Name = "Trairão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2553,
					Name = "Tucumã",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2554,
					Name = "Tucuruí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2555,
					Name = "Ulianópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2556,
					Name = "Uruará",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2557,
					Name = "Vigia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2558,
					Name = "Viseu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2559,
					Name = "Vitória do Xingu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2560,
					Name = "Xinguara",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2561,
					Name = "Água Branca",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2562,
					Name = "Aguiar",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2563,
					Name = "Alagoa Grande",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2564,
					Name = "Alagoa Nova",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2565,
					Name = "Alagoinha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2566,
					Name = "Alcantil",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2567,
					Name = "Algodão de Jandaíra",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2568,
					Name = "Alhandra",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2569,
					Name = "Amparo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2570,
					Name = "Aparecida",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2571,
					Name = "Araçagi",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2572,
					Name = "Arara",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2573,
					Name = "Araruna",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2574,
					Name = "Areia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2575,
					Name = "Areia de Baraúnas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2576,
					Name = "Areial",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2577,
					Name = "Aroeiras",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2578,
					Name = "Assunção",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2579,
					Name = "Baía da Traição",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2580,
					Name = "Bananeiras",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2581,
					Name = "Baraúna",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2582,
					Name = "Barra de Santa Rosa",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2583,
					Name = "Barra de Santana",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2584,
					Name = "Barra de São Miguel",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2585,
					Name = "Bayeux",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2586,
					Name = "Belém",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2587,
					Name = "Belém do Brejo do Cruz",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2588,
					Name = "Bernardino Batista",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2589,
					Name = "Boa Ventura",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2590,
					Name = "Boa Vista",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2591,
					Name = "Bom Jesus",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2592,
					Name = "Bom Sucesso",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2593,
					Name = "Bonito de Santa Fé",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2594,
					Name = "Boqueirão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2595,
					Name = "Borborema",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2596,
					Name = "Brejo do Cruz",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2597,
					Name = "Brejo dos Santos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2598,
					Name = "Caaporã",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2599,
					Name = "Cabaceiras",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2600,
					Name = "Cabedelo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2601,
					Name = "Cachoeira dos Índios",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2602,
					Name = "Cacimba de Areia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2603,
					Name = "Cacimba de Dentro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2604,
					Name = "Cacimbas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2605,
					Name = "Caiçara",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2606,
					Name = "Cajazeiras",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2607,
					Name = "Cajazeirinhas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2608,
					Name = "Caldas Brandão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2609,
					Name = "Camalaú",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2610,
					Name = "Campina Grande",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2611,
					Name = "Campo de Santana",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2612,
					Name = "Capim",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2613,
					Name = "Caraúbas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2614,
					Name = "Carrapateira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2615,
					Name = "Casserengue",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2616,
					Name = "Catingueira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2617,
					Name = "Catolé do Rocha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2618,
					Name = "Caturité",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2619,
					Name = "Conceição",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2620,
					Name = "Condado",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2621,
					Name = "Conde",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2622,
					Name = "Congo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2623,
					Name = "Coremas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2624,
					Name = "Coxixola",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2625,
					Name = "Cruz do Espírito Santo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2626,
					Name = "Cubati",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2627,
					Name = "Cuité",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2628,
					Name = "Cuité de Mamanguape",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2629,
					Name = "Cuitegi",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2630,
					Name = "Curral de Cima",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2631,
					Name = "Curral Velho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2632,
					Name = "Damião",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2633,
					Name = "Desterro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2634,
					Name = "Diamante",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2635,
					Name = "Dona Inês",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2636,
					Name = "Duas Estradas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2637,
					Name = "Emas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2638,
					Name = "Esperança",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2639,
					Name = "Fagundes",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2640,
					Name = "Frei Martinho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2641,
					Name = "Gado Bravo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2642,
					Name = "Guarabira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2643,
					Name = "Gurinhém",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2644,
					Name = "Gurjão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2645,
					Name = "Ibiara",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2646,
					Name = "Igaracy",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2647,
					Name = "Imaculada",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2648,
					Name = "Ingá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2649,
					Name = "Itabaiana",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2650,
					Name = "Itaporanga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2651,
					Name = "Itapororoca",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2652,
					Name = "Itatuba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2653,
					Name = "Jacaraú",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2654,
					Name = "Jericó",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2655,
					Name = "João Pessoa",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2656,
					Name = "Juarez Távora",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2657,
					Name = "Juazeirinho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2658,
					Name = "Junco do Seridó",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2659,
					Name = "Juripiranga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2660,
					Name = "Juru",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2661,
					Name = "Lagoa",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2662,
					Name = "Lagoa de Dentro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2663,
					Name = "Lagoa Seca",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2664,
					Name = "Lastro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2665,
					Name = "Livramento",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2666,
					Name = "Logradouro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2667,
					Name = "Lucena",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2668,
					Name = "Mãe d`Água",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2669,
					Name = "Malta",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2670,
					Name = "Mamanguape",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2671,
					Name = "Manaíra",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2672,
					Name = "Marcação",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2673,
					Name = "Mari",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2674,
					Name = "Marizópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2675,
					Name = "Massaranduba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2676,
					Name = "Mataraca",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2677,
					Name = "Matinhas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2678,
					Name = "Mato Grosso",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2679,
					Name = "Maturéia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2680,
					Name = "Mogeiro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2681,
					Name = "Montadas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2682,
					Name = "Monte Horebe",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2683,
					Name = "Monteiro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2684,
					Name = "Mulungu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2685,
					Name = "Natuba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2686,
					Name = "Nazarezinho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2687,
					Name = "Nova Floresta",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2688,
					Name = "Nova Olinda",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2689,
					Name = "Nova Palmeira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2690,
					Name = "Olho d`Água",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2691,
					Name = "Olivedos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2692,
					Name = "Ouro Velho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2693,
					Name = "Parari",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2694,
					Name = "Passagem",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2695,
					Name = "Patos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2696,
					Name = "Paulista",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2697,
					Name = "Pedra Branca",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2698,
					Name = "Pedra Lavrada",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2699,
					Name = "Pedras de Fogo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2700,
					Name = "Pedro Régis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2701,
					Name = "Piancó",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2702,
					Name = "Picuí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2703,
					Name = "Pilar",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2704,
					Name = "Pilões",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2705,
					Name = "Pilõezinhos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2706,
					Name = "Pirpirituba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2707,
					Name = "Pitimbu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2708,
					Name = "Pocinhos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2709,
					Name = "Poço Dantas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2710,
					Name = "Poço de José de Moura",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2711,
					Name = "Pombal",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2712,
					Name = "Prata",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2713,
					Name = "Princesa Isabel",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2714,
					Name = "Puxinanã",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2715,
					Name = "Queimadas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2716,
					Name = "Quixabá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2717,
					Name = "Remígio",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2718,
					Name = "Riachão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2719,
					Name = "Riachão do Bacamarte",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2720,
					Name = "Riachão do Poço",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2721,
					Name = "Riacho de Santo Antônio",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2722,
					Name = "Riacho dos Cavalos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2723,
					Name = "Rio Tinto",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2724,
					Name = "Salgadinho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2725,
					Name = "Salgado de São Félix",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2726,
					Name = "Santa Cecília",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2727,
					Name = "Santa Cruz",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2728,
					Name = "Santa Helena",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2729,
					Name = "Santa Inês",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2730,
					Name = "Santa Luzia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2731,
					Name = "Santa Rita",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2732,
					Name = "Santa Teresinha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2733,
					Name = "Santana de Mangueira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2734,
					Name = "Santana dos Garrotes",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2735,
					Name = "Santarém",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2736,
					Name = "Santo André",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2737,
					Name = "São Bentinho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2738,
					Name = "São Bento",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2739,
					Name = "São Domingos de Pombal",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2740,
					Name = "São Domingos do Cariri",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2741,
					Name = "São Francisco",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2742,
					Name = "São João do Cariri",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2743,
					Name = "São João do Rio do Peixe",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2744,
					Name = "São João do Tigre",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2745,
					Name = "São José da Lagoa Tapada",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2746,
					Name = "São José de Caiana",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2747,
					Name = "São José de Espinharas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2748,
					Name = "São José de Piranhas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2749,
					Name = "São José de Princesa",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2750,
					Name = "São José do Bonfim",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2751,
					Name = "São José do Brejo do Cruz",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2752,
					Name = "São José do Sabugi",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2753,
					Name = "São José dos Cordeiros",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2754,
					Name = "São José dos Ramos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2755,
					Name = "São Mamede",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2756,
					Name = "São Miguel de Taipu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2757,
					Name = "São Sebastião de Lagoa de Roça",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2758,
					Name = "São Sebastião do Umbuzeiro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2759,
					Name = "Sapé",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2760,
					Name = "Seridó",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2761,
					Name = "Serra Branca",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2762,
					Name = "Serra da Raiz",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2763,
					Name = "Serra Grande",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2764,
					Name = "Serra Redonda",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2765,
					Name = "Serraria",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2766,
					Name = "Sertãozinho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2767,
					Name = "Sobrado",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2768,
					Name = "Solânea",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2769,
					Name = "Soledade",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2770,
					Name = "Sossêgo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2771,
					Name = "Sousa",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2772,
					Name = "Sumé",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2773,
					Name = "Taperoá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2774,
					Name = "Tavares",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2775,
					Name = "Teixeira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2776,
					Name = "Tenório",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2777,
					Name = "Triunfo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2778,
					Name = "Uiraúna",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2779,
					Name = "Umbuzeiro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2780,
					Name = "Várzea",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2781,
					Name = "Vieirópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2782,
					Name = "Vista Serrana",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2783,
					Name = "Zabelê",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2784,
					Name = "Abatiá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2785,
					Name = "Adrianópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2786,
					Name = "Agudos do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2787,
					Name = "Almirante Tamandaré",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2788,
					Name = "Altamira do Paraná",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2789,
					Name = "Alto Paraíso",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2790,
					Name = "Alto Paraná",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2791,
					Name = "Alto Piquiri",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2792,
					Name = "Altônia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2793,
					Name = "Alvorada do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2794,
					Name = "Amaporã",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2795,
					Name = "Ampére",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2796,
					Name = "Anahy",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2797,
					Name = "Andirá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2798,
					Name = "Ângulo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2799,
					Name = "Antonina",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2800,
					Name = "Antônio Olinto",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2801,
					Name = "Apucarana",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2802,
					Name = "Arapongas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2803,
					Name = "Arapoti",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2804,
					Name = "Arapuã",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2805,
					Name = "Araruna",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2806,
					Name = "Araucária",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2807,
					Name = "Ariranha do Ivaí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2808,
					Name = "Assaí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2809,
					Name = "Assis Chateaubriand",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2810,
					Name = "Astorga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2811,
					Name = "Atalaia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2812,
					Name = "Balsa Nova",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2813,
					Name = "Bandeirantes",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2814,
					Name = "Barbosa Ferraz",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2815,
					Name = "Barra do Jacaré",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2816,
					Name = "Barracão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2817,
					Name = "Bela Vista da Caroba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2818,
					Name = "Bela Vista do Paraíso",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2819,
					Name = "Bituruna",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2820,
					Name = "Boa Esperança",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2821,
					Name = "Boa Esperança do Iguaçu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2822,
					Name = "Boa Ventura de São Roque",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2823,
					Name = "Boa Vista da Aparecida",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2824,
					Name = "Bocaiúva do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2825,
					Name = "Bom Jesus do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2826,
					Name = "Bom Sucesso",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2827,
					Name = "Bom Sucesso do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2828,
					Name = "Borrazópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2829,
					Name = "Braganey",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2830,
					Name = "Brasilândia do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2831,
					Name = "Cafeara",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2832,
					Name = "Cafelândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2833,
					Name = "Cafezal do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2834,
					Name = "Califórnia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2835,
					Name = "Cambará",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2836,
					Name = "Cambé",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2837,
					Name = "Cambira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2838,
					Name = "Campina da Lagoa",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2839,
					Name = "Campina do Simão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2840,
					Name = "Campina Grande do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2841,
					Name = "Campo Bonito",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2842,
					Name = "Campo do Tenente",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2843,
					Name = "Campo Largo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2844,
					Name = "Campo Magro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2845,
					Name = "Campo Mourão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2846,
					Name = "Cândido de Abreu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2847,
					Name = "Candói",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2848,
					Name = "Cantagalo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2849,
					Name = "Capanema",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2850,
					Name = "Capitão Leônidas Marques",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2851,
					Name = "Carambeí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2852,
					Name = "Carlópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2853,
					Name = "Cascavel",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2854,
					Name = "Castro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2855,
					Name = "Catanduvas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2856,
					Name = "Centenário do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2857,
					Name = "Cerro Azul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2858,
					Name = "Céu Azul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2859,
					Name = "Chopinzinho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2860,
					Name = "Cianorte",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2861,
					Name = "Cidade Gaúcha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2862,
					Name = "Clevelândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2863,
					Name = "Colombo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2864,
					Name = "Colorado",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2865,
					Name = "Congonhinhas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2866,
					Name = "Conselheiro Mairinck",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2867,
					Name = "Contenda",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2868,
					Name = "Corbélia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2869,
					Name = "Cornélio Procópio",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2870,
					Name = "Coronel Domingos Soares",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2871,
					Name = "Coronel Vivida",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2872,
					Name = "Corumbataí do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2873,
					Name = "Cruz Machado",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2874,
					Name = "Cruzeiro do Iguaçu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2875,
					Name = "Cruzeiro do Oeste",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2876,
					Name = "Cruzeiro do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2877,
					Name = "Cruzmaltina",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2878,
					Name = "Curitiba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2879,
					Name = "Curiúva",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2880,
					Name = "Diamante d`Oeste",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2881,
					Name = "Diamante do Norte",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2882,
					Name = "Diamante do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2883,
					Name = "Dois Vizinhos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2884,
					Name = "Douradina",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2885,
					Name = "Doutor Camargo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2886,
					Name = "Doutor Ulysses",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2887,
					Name = "Enéas Marques",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2888,
					Name = "Engenheiro Beltrão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2889,
					Name = "Entre Rios do Oeste",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2890,
					Name = "Esperança Nova",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2891,
					Name = "Espigão Alto do Iguaçu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2892,
					Name = "Farol",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2893,
					Name = "Faxinal",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2894,
					Name = "Fazenda Rio Grande",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2895,
					Name = "Fênix",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2896,
					Name = "Fernandes Pinheiro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2897,
					Name = "Figueira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2898,
					Name = "Flor da Serra do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2899,
					Name = "Floraí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2900,
					Name = "Floresta",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2901,
					Name = "Florestópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2902,
					Name = "Flórida",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2903,
					Name = "Formosa do Oeste",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2904,
					Name = "Foz do Iguaçu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2905,
					Name = "Foz do Jordão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2906,
					Name = "Francisco Alves",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2907,
					Name = "Francisco Beltrão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2908,
					Name = "General Carneiro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2909,
					Name = "Godoy Moreira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2910,
					Name = "Goioerê",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2911,
					Name = "Goioxim",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2912,
					Name = "Grandes Rios",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2913,
					Name = "Guaíra",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2914,
					Name = "Guairaçá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2915,
					Name = "Guamiranga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2916,
					Name = "Guapirama",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2917,
					Name = "Guaporema",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2918,
					Name = "Guaraci",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2919,
					Name = "Guaraniaçu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2920,
					Name = "Guarapuava",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2921,
					Name = "Guaraqueçaba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2922,
					Name = "Guaratuba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2923,
					Name = "Honório Serpa",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2924,
					Name = "Ibaiti",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2925,
					Name = "Ibema",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2926,
					Name = "Ibiporã",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2927,
					Name = "Icaraíma",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2928,
					Name = "Iguaraçu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2929,
					Name = "Iguatu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2930,
					Name = "Imbaú",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2931,
					Name = "Imbituva",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2932,
					Name = "Inácio Martins",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2933,
					Name = "Inajá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2934,
					Name = "Indianópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2935,
					Name = "Ipiranga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2936,
					Name = "Iporã",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2937,
					Name = "Iracema do Oeste",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2938,
					Name = "Irati",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2939,
					Name = "Iretama",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2940,
					Name = "Itaguajé",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2941,
					Name = "Itaipulândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2942,
					Name = "Itambaracá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2943,
					Name = "Itambé",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2944,
					Name = "Itapejara d`Oeste",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2945,
					Name = "Itaperuçu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2946,
					Name = "Itaúna do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2947,
					Name = "Ivaí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2948,
					Name = "Ivaiporã",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2949,
					Name = "Ivaté",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2950,
					Name = "Ivatuba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2951,
					Name = "Jaboti",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2952,
					Name = "Jacarezinho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2953,
					Name = "Jaguapitã",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2954,
					Name = "Jaguariaíva",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2955,
					Name = "Jandaia do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2956,
					Name = "Janiópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2957,
					Name = "Japira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2958,
					Name = "Japurá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2959,
					Name = "Jardim Alegre",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2960,
					Name = "Jardim Olinda",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2961,
					Name = "Jataizinho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2962,
					Name = "Jesuítas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2963,
					Name = "Joaquim Távora",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2964,
					Name = "Jundiaí do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2965,
					Name = "Juranda",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2966,
					Name = "Jussara",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2967,
					Name = "Kaloré",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2968,
					Name = "Lapa",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2969,
					Name = "Laranjal",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2970,
					Name = "Laranjeiras do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2971,
					Name = "Leópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2972,
					Name = "Lidianópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2973,
					Name = "Lindoeste",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2974,
					Name = "Loanda",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2975,
					Name = "Lobato",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2976,
					Name = "Londrina",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2977,
					Name = "Luiziana",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2978,
					Name = "Lunardelli",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2979,
					Name = "Lupionópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2980,
					Name = "Mallet",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2981,
					Name = "Mamborê",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2982,
					Name = "Mandaguaçu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2983,
					Name = "Mandaguari",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2984,
					Name = "Mandirituba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2985,
					Name = "Manfrinópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2986,
					Name = "Mangueirinha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2987,
					Name = "Manoel Ribas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2988,
					Name = "Marechal Cândido Rondon",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2989,
					Name = "Maria Helena",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2990,
					Name = "Marialva",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2991,
					Name = "Marilândia do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2992,
					Name = "Marilena",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2993,
					Name = "Mariluz",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2994,
					Name = "Maringá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2995,
					Name = "Mariópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2996,
					Name = "Maripá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2997,
					Name = "Marmeleiro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2998,
					Name = "Marquinho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 2999,
					Name = "Marumbi",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3000,
					Name = "Matelândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3001,
					Name = "Matinhos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3002,
					Name = "Mato Rico",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3003,
					Name = "Mauá da Serra",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3004,
					Name = "Medianeira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3005,
					Name = "Mercedes",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3006,
					Name = "Mirador",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3007,
					Name = "Miraselva",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3008,
					Name = "Missal",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3009,
					Name = "Moreira Sales",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3010,
					Name = "Morretes",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3011,
					Name = "Munhoz de Melo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3012,
					Name = "Nossa Senhora das Graças",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3013,
					Name = "Nova Aliança do Ivaí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3014,
					Name = "Nova América da Colina",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3015,
					Name = "Nova Aurora",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3016,
					Name = "Nova Cantu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3017,
					Name = "Nova Esperança",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3018,
					Name = "Nova Esperança do Sudoeste",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3019,
					Name = "Nova Fátima",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3020,
					Name = "Nova Laranjeiras",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3021,
					Name = "Nova Londrina",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3022,
					Name = "Nova Olímpia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3023,
					Name = "Nova Prata do Iguaçu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3024,
					Name = "Nova Santa Bárbara",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3025,
					Name = "Nova Santa Rosa",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3026,
					Name = "Nova Tebas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3027,
					Name = "Novo Itacolomi",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3028,
					Name = "Ortigueira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3029,
					Name = "Ourizona",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3030,
					Name = "Ouro Verde do Oeste",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3031,
					Name = "Paiçandu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3032,
					Name = "Palmas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3033,
					Name = "Palmeira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3034,
					Name = "Palmital",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3035,
					Name = "Palotina",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3036,
					Name = "Paraíso do Norte",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3037,
					Name = "Paranacity",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3038,
					Name = "Paranaguá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3039,
					Name = "Paranapoema",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3040,
					Name = "Paranavaí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3041,
					Name = "Pato Bragado",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3042,
					Name = "Pato Branco",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3043,
					Name = "Paula Freitas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3044,
					Name = "Paulo Frontin",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3045,
					Name = "Peabiru",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3046,
					Name = "Perobal",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3047,
					Name = "Pérola",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3048,
					Name = "Pérola d`Oeste",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3049,
					Name = "Piên",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3050,
					Name = "Pinhais",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3051,
					Name = "Pinhal de São Bento",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3052,
					Name = "Pinhalão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3053,
					Name = "Pinhão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3054,
					Name = "Piraí do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3055,
					Name = "Piraquara",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3056,
					Name = "Pitanga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3057,
					Name = "Pitangueiras",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3058,
					Name = "Planaltina do Paraná",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3059,
					Name = "Planalto",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3060,
					Name = "Ponta Grossa",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3061,
					Name = "Pontal do Paraná",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3062,
					Name = "Porecatu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3063,
					Name = "Porto Amazonas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3064,
					Name = "Porto Barreiro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3065,
					Name = "Porto Rico",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3066,
					Name = "Porto Vitória",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3067,
					Name = "Prado Ferreira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3068,
					Name = "Pranchita",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3069,
					Name = "Presidente Castelo Branco",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3070,
					Name = "Primeiro de Maio",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3071,
					Name = "Prudentópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3072,
					Name = "Quarto Centenário",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3073,
					Name = "Quatiguá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3074,
					Name = "Quatro Barras",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3075,
					Name = "Quatro Pontes",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3076,
					Name = "Quedas do Iguaçu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3077,
					Name = "Querência do Norte",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3078,
					Name = "Quinta do Sol",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3079,
					Name = "Quitandinha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3080,
					Name = "Ramilândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3081,
					Name = "Rancho Alegre",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3082,
					Name = "Rancho Alegre d`Oeste",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3083,
					Name = "Realeza",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3084,
					Name = "Rebouças",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3085,
					Name = "Renascença",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3086,
					Name = "Reserva",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3087,
					Name = "Reserva do Iguaçu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3088,
					Name = "Ribeirão Claro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3089,
					Name = "Ribeirão do Pinhal",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3090,
					Name = "Rio Azul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3091,
					Name = "Rio Bom",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3092,
					Name = "Rio Bonito do Iguaçu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3093,
					Name = "Rio Branco do Ivaí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3094,
					Name = "Rio Branco do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3095,
					Name = "Rio Negro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3096,
					Name = "Rolândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3097,
					Name = "Roncador",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3098,
					Name = "Rondon",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3099,
					Name = "Rosário do Ivaí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3100,
					Name = "Sabáudia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3101,
					Name = "Salgado Filho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3102,
					Name = "Salto do Itararé",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3103,
					Name = "Salto do Lontra",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3104,
					Name = "Santa Amélia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3105,
					Name = "Santa Cecília do Pavão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3106,
					Name = "Santa Cruz de Monte Castelo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3107,
					Name = "Santa Fé",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3108,
					Name = "Santa Helena",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3109,
					Name = "Santa Inês",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3110,
					Name = "Santa Isabel do Ivaí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3111,
					Name = "Santa Izabel do Oeste",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3112,
					Name = "Santa Lúcia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3113,
					Name = "Santa Maria do Oeste",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3114,
					Name = "Santa Mariana",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3115,
					Name = "Santa Mônica",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3116,
					Name = "Santa Tereza do Oeste",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3117,
					Name = "Santa Terezinha de Itaipu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3118,
					Name = "Santana do Itararé",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3119,
					Name = "Santo Antônio da Platina",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3120,
					Name = "Santo Antônio do Caiuá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3121,
					Name = "Santo Antônio do Paraíso",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3122,
					Name = "Santo Antônio do Sudoeste",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3123,
					Name = "Santo Inácio",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3124,
					Name = "São Carlos do Ivaí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3125,
					Name = "São Jerônimo da Serra",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3126,
					Name = "São João",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3127,
					Name = "São João do Caiuá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3128,
					Name = "São João do Ivaí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3129,
					Name = "São João do Triunfo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3130,
					Name = "São Jorge d`Oeste",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3131,
					Name = "São Jorge do Ivaí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3132,
					Name = "São Jorge do Patrocínio",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3133,
					Name = "São José da Boa Vista",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3134,
					Name = "São José das Palmeiras",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3135,
					Name = "São José dos Pinhais",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3136,
					Name = "São Manoel do Paraná",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3137,
					Name = "São Mateus do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3138,
					Name = "São Miguel do Iguaçu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3139,
					Name = "São Pedro do Iguaçu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3140,
					Name = "São Pedro do Ivaí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3141,
					Name = "São Pedro do Paraná",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3142,
					Name = "São Sebastião da Amoreira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3143,
					Name = "São Tomé",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3144,
					Name = "Sapopema",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3145,
					Name = "Sarandi",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3146,
					Name = "Saudade do Iguaçu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3147,
					Name = "Sengés",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3148,
					Name = "Serranópolis do Iguaçu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3149,
					Name = "Sertaneja",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3150,
					Name = "Sertanópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3151,
					Name = "Siqueira Campos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3152,
					Name = "Sulina",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3153,
					Name = "Tamarana",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3154,
					Name = "Tamboara",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3155,
					Name = "Tapejara",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3156,
					Name = "Tapira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3157,
					Name = "Teixeira Soares",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3158,
					Name = "Telêmaco Borba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3159,
					Name = "Terra Boa",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3160,
					Name = "Terra Rica",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3161,
					Name = "Terra Roxa",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3162,
					Name = "Tibagi",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3163,
					Name = "Tijucas do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3164,
					Name = "Toledo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3165,
					Name = "Tomazina",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3166,
					Name = "Três Barras do Paraná",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3167,
					Name = "Tunas do Paraná",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3168,
					Name = "Tuneiras do Oeste",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3169,
					Name = "Tupãssi",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3170,
					Name = "Turvo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3171,
					Name = "Ubiratã",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3172,
					Name = "Umuarama",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3173,
					Name = "União da Vitória",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3174,
					Name = "Uniflor",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3175,
					Name = "Uraí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3176,
					Name = "Ventania",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3177,
					Name = "Vera Cruz do Oeste",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3178,
					Name = "Verê",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3179,
					Name = "Virmond",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3180,
					Name = "Vitorino",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3181,
					Name = "Wenceslau Braz",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3182,
					Name = "Xambrê",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3183,
					Name = "Abreu e Lima",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3184,
					Name = "Afogados da Ingazeira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3185,
					Name = "Afrânio",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3186,
					Name = "Agrestina",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3187,
					Name = "Água Preta",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3188,
					Name = "Águas Belas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3189,
					Name = "Alagoinha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3190,
					Name = "Aliança",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3191,
					Name = "Altinho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3192,
					Name = "Amaraji",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3193,
					Name = "Angelim",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3194,
					Name = "Araçoiaba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3195,
					Name = "Araripina",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3196,
					Name = "Arcoverde",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3197,
					Name = "Barra de Guabiraba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3198,
					Name = "Barreiros",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3199,
					Name = "Belém de Maria",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3200,
					Name = "Belém de São Francisco",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3201,
					Name = "Belo Jardim",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3202,
					Name = "Betânia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3203,
					Name = "Bezerros",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3204,
					Name = "Bodocó",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3205,
					Name = "Bom Conselho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3206,
					Name = "Bom Jardim",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3207,
					Name = "Bonito",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3208,
					Name = "Brejão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3209,
					Name = "Brejinho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3210,
					Name = "Brejo da Madre de Deus",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3211,
					Name = "Buenos Aires",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3212,
					Name = "Buíque",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3213,
					Name = "Cabo de Santo Agostinho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3214,
					Name = "Cabrobó",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3215,
					Name = "Cachoeirinha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3216,
					Name = "Caetés",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3217,
					Name = "Calçado",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3218,
					Name = "Calumbi",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3219,
					Name = "Camaragibe",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3220,
					Name = "Camocim de São Félix",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3221,
					Name = "Camutanga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3222,
					Name = "Canhotinho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3223,
					Name = "Capoeiras",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3224,
					Name = "Carnaíba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3225,
					Name = "Carnaubeira da Penha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3226,
					Name = "Carpina",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3227,
					Name = "Caruaru",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3228,
					Name = "Casinhas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3229,
					Name = "Catende",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3230,
					Name = "Cedro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3231,
					Name = "Chã de Alegria",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3232,
					Name = "Chã Grande",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3233,
					Name = "Condado",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3234,
					Name = "Correntes",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3235,
					Name = "Cortês",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3236,
					Name = "Cumaru",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3237,
					Name = "Cupira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3238,
					Name = "Custódia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3239,
					Name = "Dormentes",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3240,
					Name = "Escada",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3241,
					Name = "Exu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3242,
					Name = "Feira Nova",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3243,
					Name = "Fernando de Noronha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3244,
					Name = "Ferreiros",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3245,
					Name = "Flores",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3246,
					Name = "Floresta",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3247,
					Name = "Frei Miguelinho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3248,
					Name = "Gameleira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3249,
					Name = "Garanhuns",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3250,
					Name = "Glória do Goitá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3251,
					Name = "Goiana",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3252,
					Name = "Granito",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3253,
					Name = "Gravatá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3254,
					Name = "Iati",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3255,
					Name = "Ibimirim",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3256,
					Name = "Ibirajuba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3257,
					Name = "Igarassu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3258,
					Name = "Iguaraci",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3259,
					Name = "Ilha de Itamaracá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3260,
					Name = "Inajá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3261,
					Name = "Ingazeira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3262,
					Name = "Ipojuca",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3263,
					Name = "Ipubi",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3264,
					Name = "Itacuruba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3265,
					Name = "Itaíba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3266,
					Name = "Itambé",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3267,
					Name = "Itapetim",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3268,
					Name = "Itapissuma",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3269,
					Name = "Itaquitinga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3270,
					Name = "Jaboatão dos Guararapes",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3271,
					Name = "Jaqueira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3272,
					Name = "Jataúba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3273,
					Name = "Jatobá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3274,
					Name = "João Alfredo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3275,
					Name = "Joaquim Nabuco",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3276,
					Name = "Jucati",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3277,
					Name = "Jupi",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3278,
					Name = "Jurema",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3279,
					Name = "Lagoa do Carro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3280,
					Name = "Lagoa do Itaenga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3281,
					Name = "Lagoa do Ouro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3282,
					Name = "Lagoa dos Gatos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3283,
					Name = "Lagoa Grande",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3284,
					Name = "Lajedo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3285,
					Name = "Limoeiro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3286,
					Name = "Macaparana",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3287,
					Name = "Machados",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3288,
					Name = "Manari",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3289,
					Name = "Maraial",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3290,
					Name = "Mirandiba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3291,
					Name = "Moreilândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3292,
					Name = "Moreno",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3293,
					Name = "Nazaré da Mata",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3294,
					Name = "Olinda",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3295,
					Name = "Orobó",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3296,
					Name = "Orocó",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3297,
					Name = "Ouricuri",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3298,
					Name = "Palmares",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3299,
					Name = "Palmeirina",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3300,
					Name = "Panelas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3301,
					Name = "Paranatama",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3302,
					Name = "Parnamirim",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3303,
					Name = "Passira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3304,
					Name = "Paudalho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3305,
					Name = "Paulista",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3306,
					Name = "Pedra",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3307,
					Name = "Pesqueira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3308,
					Name = "Petrolândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3309,
					Name = "Petrolina",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3310,
					Name = "Poção",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3311,
					Name = "Pombos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3312,
					Name = "Primavera",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3313,
					Name = "Quipapá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3314,
					Name = "Quixaba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3315,
					Name = "Recife",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3316,
					Name = "Riacho das Almas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3317,
					Name = "Ribeirão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3318,
					Name = "Rio Formoso",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3319,
					Name = "Sairé",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3320,
					Name = "Salgadinho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3321,
					Name = "Salgueiro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3322,
					Name = "Saloá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3323,
					Name = "Sanharó",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3324,
					Name = "Santa Cruz",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3325,
					Name = "Santa Cruz da Baixa Verde",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3326,
					Name = "Santa Cruz do Capibaribe",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3327,
					Name = "Santa Filomena",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3328,
					Name = "Santa Maria da Boa Vista",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3329,
					Name = "Santa Maria do Cambucá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3330,
					Name = "Santa Terezinha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3331,
					Name = "São Benedito do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3332,
					Name = "São Bento do Una",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3333,
					Name = "São Caitano",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3334,
					Name = "São João",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3335,
					Name = "São Joaquim do Monte",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3336,
					Name = "São José da Coroa Grande",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3337,
					Name = "São José do Belmonte",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3338,
					Name = "São José do Egito",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3339,
					Name = "São Lourenço da Mata",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3340,
					Name = "São Vicente Ferrer",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3341,
					Name = "Serra Talhada",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3342,
					Name = "Serrita",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3343,
					Name = "Sertânia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3344,
					Name = "Sirinhaém",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3345,
					Name = "Solidão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3346,
					Name = "Surubim",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3347,
					Name = "Tabira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3348,
					Name = "Tacaimbó",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3349,
					Name = "Tacaratu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3350,
					Name = "Tamandaré",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3351,
					Name = "Taquaritinga do Norte",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3352,
					Name = "Terezinha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3353,
					Name = "Terra Nova",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3354,
					Name = "Timbaúba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3355,
					Name = "Toritama",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3356,
					Name = "Tracunhaém",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3357,
					Name = "Trindade",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3358,
					Name = "Triunfo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3359,
					Name = "Tupanatinga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3360,
					Name = "Tuparetama",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3361,
					Name = "Venturosa",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3362,
					Name = "Verdejante",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3363,
					Name = "Vertente do Lério",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3364,
					Name = "Vertentes",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3365,
					Name = "Vicência",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3366,
					Name = "Vitória de Santo Antão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3367,
					Name = "Xexéu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3368,
					Name = "Acauã",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3369,
					Name = "Agricolândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3370,
					Name = "Água Branca",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3371,
					Name = "Alagoinha do Piauí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3372,
					Name = "Alegrete do Piauí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3373,
					Name = "Alto Longá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3374,
					Name = "Altos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3375,
					Name = "Alvorada do Gurguéia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3376,
					Name = "Amarante",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3377,
					Name = "Angical do Piauí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3378,
					Name = "Anísio de Abreu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3379,
					Name = "Antônio Almeida",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3380,
					Name = "Aroazes",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3381,
					Name = "Aroeiras do Itaim",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3382,
					Name = "Arraial",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3383,
					Name = "Assunção do Piauí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3384,
					Name = "Avelino Lopes",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3385,
					Name = "Baixa Grande do Ribeiro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3386,
					Name = "Barra d`Alcântara",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3387,
					Name = "Barras",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3388,
					Name = "Barreiras do Piauí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3389,
					Name = "Barro Duro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3390,
					Name = "Batalha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3391,
					Name = "Bela Vista do Piauí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3392,
					Name = "Belém do Piauí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3393,
					Name = "Beneditinos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3394,
					Name = "Bertolínia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3395,
					Name = "Betânia do Piauí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3396,
					Name = "Boa Hora",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3397,
					Name = "Bocaina",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3398,
					Name = "Bom Jesus",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3399,
					Name = "Bom Princípio do Piauí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3400,
					Name = "Bonfim do Piauí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3401,
					Name = "Boqueirão do Piauí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3402,
					Name = "Brasileira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3403,
					Name = "Brejo do Piauí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3404,
					Name = "Buriti dos Lopes",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3405,
					Name = "Buriti dos Montes",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3406,
					Name = "Cabeceiras do Piauí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3407,
					Name = "Cajazeiras do Piauí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3408,
					Name = "Cajueiro da Praia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3409,
					Name = "Caldeirão Grande do Piauí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3410,
					Name = "Campinas do Piauí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3411,
					Name = "Campo Alegre do Fidalgo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3412,
					Name = "Campo Grande do Piauí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3413,
					Name = "Campo Largo do Piauí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3414,
					Name = "Campo Maior",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3415,
					Name = "Canavieira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3416,
					Name = "Canto do Buriti",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3417,
					Name = "Capitão de Campos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3418,
					Name = "Capitão Gervásio Oliveira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3419,
					Name = "Caracol",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3420,
					Name = "Caraúbas do Piauí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3421,
					Name = "Caridade do Piauí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3422,
					Name = "Castelo do Piauí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3423,
					Name = "Caxingó",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3424,
					Name = "Cocal",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3425,
					Name = "Cocal de Telha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3426,
					Name = "Cocal dos Alves",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3427,
					Name = "Coivaras",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3428,
					Name = "Colônia do Gurguéia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3429,
					Name = "Colônia do Piauí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3430,
					Name = "Conceição do Canindé",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3431,
					Name = "Coronel José Dias",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3432,
					Name = "Corrente",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3433,
					Name = "Cristalândia do Piauí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3434,
					Name = "Cristino Castro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3435,
					Name = "Curimatá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3436,
					Name = "Currais",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3437,
					Name = "Curral Novo do Piauí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3438,
					Name = "Curralinhos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3439,
					Name = "Demerval Lobão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3440,
					Name = "Dirceu Arcoverde",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3441,
					Name = "Dom Expedito Lopes",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3442,
					Name = "Dom Inocêncio",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3443,
					Name = "Domingos Mourão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3444,
					Name = "Elesbão Veloso",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3445,
					Name = "Eliseu Martins",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3446,
					Name = "Esperantina",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3447,
					Name = "Fartura do Piauí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3448,
					Name = "Flores do Piauí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3449,
					Name = "Floresta do Piauí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3450,
					Name = "Floriano",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3451,
					Name = "Francinópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3452,
					Name = "Francisco Ayres",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3453,
					Name = "Francisco Macedo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3454,
					Name = "Francisco Santos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3455,
					Name = "Fronteiras",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3456,
					Name = "Geminiano",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3457,
					Name = "Gilbués",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3458,
					Name = "Guadalupe",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3459,
					Name = "Guaribas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3460,
					Name = "Hugo Napoleão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3461,
					Name = "Ilha Grande",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3462,
					Name = "Inhuma",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3463,
					Name = "Ipiranga do Piauí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3464,
					Name = "Isaías Coelho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3465,
					Name = "Itainópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3466,
					Name = "Itaueira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3467,
					Name = "Jacobina do Piauí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3468,
					Name = "Jaicós",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3469,
					Name = "Jardim do Mulato",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3470,
					Name = "Jatobá do Piauí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3471,
					Name = "Jerumenha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3472,
					Name = "João Costa",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3473,
					Name = "Joaquim Pires",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3474,
					Name = "Joca Marques",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3475,
					Name = "José de Freitas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3476,
					Name = "Juazeiro do Piauí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3477,
					Name = "Júlio Borges",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3478,
					Name = "Jurema",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3479,
					Name = "Lagoa Alegre",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3480,
					Name = "Lagoa de São Francisco",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3481,
					Name = "Lagoa do Barro do Piauí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3482,
					Name = "Lagoa do Piauí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3483,
					Name = "Lagoa do Sítio",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3484,
					Name = "Lagoinha do Piauí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3485,
					Name = "Landri Sales",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3486,
					Name = "Luís Correia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3487,
					Name = "Luzilândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3488,
					Name = "Madeiro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3489,
					Name = "Manoel Emídio",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3490,
					Name = "Marcolândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3491,
					Name = "Marcos Parente",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3492,
					Name = "Massapê do Piauí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3493,
					Name = "Matias Olímpio",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3494,
					Name = "Miguel Alves",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3495,
					Name = "Miguel Leão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3496,
					Name = "Milton Brandão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3497,
					Name = "Monsenhor Gil",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3498,
					Name = "Monsenhor Hipólito",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3499,
					Name = "Monte Alegre do Piauí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3500,
					Name = "Morro Cabeça no Tempo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3501,
					Name = "Morro do Chapéu do Piauí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3502,
					Name = "Murici dos Portelas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3503,
					Name = "Nazaré do Piauí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3504,
					Name = "Nossa Senhora de Nazaré",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3505,
					Name = "Nossa Senhora dos Remédios",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3506,
					Name = "Nova Santa Rita",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3507,
					Name = "Novo Oriente do Piauí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3508,
					Name = "Novo Santo Antônio",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3509,
					Name = "Oeiras",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3510,
					Name = "Olho d`Água do Piauí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3511,
					Name = "Padre Marcos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3512,
					Name = "Paes Landim",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3513,
					Name = "Pajeú do Piauí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3514,
					Name = "Palmeira do Piauí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3515,
					Name = "Palmeirais",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3516,
					Name = "Paquetá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3517,
					Name = "Parnaguá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3518,
					Name = "Parnaíba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3519,
					Name = "Passagem Franca do Piauí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3520,
					Name = "Patos do Piauí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3521,
					Name = "Pau d`Arco do Piauí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3522,
					Name = "Paulistana",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3523,
					Name = "Pavussu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3524,
					Name = "Pedro II",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3525,
					Name = "Pedro Laurentino",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3526,
					Name = "Picos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3527,
					Name = "Pimenteiras",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3528,
					Name = "Pio IX",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3529,
					Name = "Piracuruca",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3530,
					Name = "Piripiri",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3531,
					Name = "Porto",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3532,
					Name = "Porto Alegre do Piauí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3533,
					Name = "Prata do Piauí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3534,
					Name = "Queimada Nova",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3535,
					Name = "Redenção do Gurguéia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3536,
					Name = "Regeneração",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3537,
					Name = "Riacho Frio",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3538,
					Name = "Ribeira do Piauí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3539,
					Name = "Ribeiro Gonçalves",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3540,
					Name = "Rio Grande do Piauí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3541,
					Name = "Santa Cruz do Piauí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3542,
					Name = "Santa Cruz dos Milagres",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3543,
					Name = "Santa Filomena",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3544,
					Name = "Santa Luz",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3545,
					Name = "Santa Rosa do Piauí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3546,
					Name = "Santana do Piauí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3547,
					Name = "Santo Antônio de Lisboa",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3548,
					Name = "Santo Antônio dos Milagres",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3549,
					Name = "Santo Inácio do Piauí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3550,
					Name = "São Braz do Piauí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3551,
					Name = "São Félix do Piauí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3552,
					Name = "São Francisco de Assis do Piauí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3553,
					Name = "São Francisco do Piauí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3554,
					Name = "São Gonçalo do Gurguéia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3555,
					Name = "São Gonçalo do Piauí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3556,
					Name = "São João da Canabrava",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3557,
					Name = "São João da Fronteira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3558,
					Name = "São João da Serra",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3559,
					Name = "São João da Varjota",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3560,
					Name = "São João do Arraial",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3561,
					Name = "São João do Piauí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3562,
					Name = "São José do Divino",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3563,
					Name = "São José do Peixe",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3564,
					Name = "São José do Piauí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3565,
					Name = "São Julião",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3566,
					Name = "São Lourenço do Piauí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3567,
					Name = "São Luis do Piauí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3568,
					Name = "São Miguel da Baixa Grande",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3569,
					Name = "São Miguel do Fidalgo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3570,
					Name = "São Miguel do Tapuio",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3571,
					Name = "São Pedro do Piauí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3572,
					Name = "São Raimundo Nonato",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3573,
					Name = "Sebastião Barros",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3574,
					Name = "Sebastião Leal",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3575,
					Name = "Sigefredo Pacheco",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3576,
					Name = "Simões",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3577,
					Name = "Simplício Mendes",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3578,
					Name = "Socorro do Piauí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3579,
					Name = "Sussuapara",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3580,
					Name = "Tamboril do Piauí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3581,
					Name = "Tanque do Piauí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3582,
					Name = "Teresina",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3583,
					Name = "União",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3584,
					Name = "Uruçuí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3585,
					Name = "Valença do Piauí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3586,
					Name = "Várzea Branca",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3587,
					Name = "Várzea Grande",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3588,
					Name = "Vera Mendes",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3589,
					Name = "Vila Nova do Piauí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3590,
					Name = "Wall Ferraz",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3591,
					Name = "Angra dos Reis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3592,
					Name = "Aperibé",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3593,
					Name = "Araruama",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3594,
					Name = "Areal",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3595,
					Name = "Armação dos Búzios",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3596,
					Name = "Arraial do Cabo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3597,
					Name = "Barra do Piraí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3598,
					Name = "Barra Mansa",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3599,
					Name = "Belford Roxo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3600,
					Name = "Bom Jardim",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3601,
					Name = "Bom Jesus do Itabapoana",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3602,
					Name = "Cabo Frio",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3603,
					Name = "Cachoeiras de Macacu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3604,
					Name = "Cambuci",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3605,
					Name = "Campos dos Goytacazes",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3606,
					Name = "Cantagalo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3607,
					Name = "Carapebus",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3608,
					Name = "Cardoso Moreira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3609,
					Name = "Carmo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3610,
					Name = "Casimiro de Abreu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3611,
					Name = "Comendador Levy Gasparian",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3612,
					Name = "Conceição de Macabu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3613,
					Name = "Cordeiro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3614,
					Name = "Duas Barras",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3615,
					Name = "Duque de Caxias",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3616,
					Name = "Engenheiro Paulo de Frontin",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3617,
					Name = "Guapimirim",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3618,
					Name = "Iguaba Grande",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3619,
					Name = "Itaboraí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3620,
					Name = "Itaguaí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3621,
					Name = "Italva",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3622,
					Name = "Itaocara",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3623,
					Name = "Itaperuna",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3624,
					Name = "Itatiaia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3625,
					Name = "Japeri",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3626,
					Name = "Laje do Muriaé",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3627,
					Name = "Macaé",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3628,
					Name = "Macuco",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3629,
					Name = "Magé",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3630,
					Name = "Mangaratiba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3631,
					Name = "Maricá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3632,
					Name = "Mendes",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3633,
					Name = "Mesquita",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3634,
					Name = "Miguel Pereira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3635,
					Name = "Miracema",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3636,
					Name = "Natividade",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3637,
					Name = "Nilópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3638,
					Name = "Niterói",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3639,
					Name = "Nova Friburgo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3640,
					Name = "Nova Iguaçu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3641,
					Name = "Paracambi",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3642,
					Name = "Paraíba do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3643,
					Name = "Parati",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3644,
					Name = "Paty do Alferes",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3645,
					Name = "Petrópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3646,
					Name = "Pinheiral",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3647,
					Name = "Piraí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3648,
					Name = "Porciúncula",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3649,
					Name = "Porto Real",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3650,
					Name = "Quatis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3651,
					Name = "Queimados",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3652,
					Name = "Quissamã",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3653,
					Name = "Resende",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3654,
					Name = "Rio Bonito",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3655,
					Name = "Rio Claro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3656,
					Name = "Rio das Flores",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3657,
					Name = "Rio das Ostras",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3658,
					Name = "Rio de Janeiro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3659,
					Name = "Santa Maria Madalena",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3660,
					Name = "Santo Antônio de Pádua",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3661,
					Name = "São Fidélis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3662,
					Name = "São Francisco de Itabapoana",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3663,
					Name = "São Gonçalo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3664,
					Name = "São João da Barra",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3665,
					Name = "São João de Meriti",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3666,
					Name = "São José de Ubá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3667,
					Name = "São José do Vale do Rio Preto",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3668,
					Name = "São Pedro da Aldeia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3669,
					Name = "São Sebastião do Alto",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3670,
					Name = "Sapucaia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3671,
					Name = "Saquarema",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3672,
					Name = "Seropédica",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3673,
					Name = "Silva Jardim",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3674,
					Name = "Sumidouro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3675,
					Name = "Tanguá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3676,
					Name = "Teresópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3677,
					Name = "Trajano de Morais",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3678,
					Name = "Três Rios",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3679,
					Name = "Valença",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3680,
					Name = "Varre-Sai",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3681,
					Name = "Vassouras",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3682,
					Name = "Volta Redonda",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3683,
					Name = "Acari",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3684,
					Name = "Açu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3685,
					Name = "Afonso Bezerra",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3686,
					Name = "Água Nova",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3687,
					Name = "Alexandria",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3688,
					Name = "Almino Afonso",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3689,
					Name = "Alto do Rodrigues",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3690,
					Name = "Angicos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3691,
					Name = "Antônio Martins",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3692,
					Name = "Apodi",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3693,
					Name = "Areia Branca",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3694,
					Name = "Arês",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3695,
					Name = "Augusto Severo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3696,
					Name = "Baía Formosa",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3697,
					Name = "Baraúna",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3698,
					Name = "Barcelona",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3699,
					Name = "Bento Fernandes",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3700,
					Name = "Bodó",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3701,
					Name = "Bom Jesus",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3702,
					Name = "Brejinho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3703,
					Name = "Caiçara do Norte",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3704,
					Name = "Caiçara do Rio do Vento",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3705,
					Name = "Caicó",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3706,
					Name = "Campo Redondo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3707,
					Name = "Canguaretama",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3708,
					Name = "Caraúbas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3709,
					Name = "Carnaúba dos Dantas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3710,
					Name = "Carnaubais",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3711,
					Name = "Ceará-Mirim",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3712,
					Name = "Cerro Corá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3713,
					Name = "Coronel Ezequiel",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3714,
					Name = "Coronel João Pessoa",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3715,
					Name = "Cruzeta",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3716,
					Name = "Currais Novos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3717,
					Name = "Doutor Severiano",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3718,
					Name = "Encanto",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3719,
					Name = "Equador",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3720,
					Name = "Espírito Santo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3721,
					Name = "Extremoz",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3722,
					Name = "Felipe Guerra",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3723,
					Name = "Fernando Pedroza",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3724,
					Name = "Florânia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3725,
					Name = "Francisco Dantas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3726,
					Name = "Frutuoso Gomes",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3727,
					Name = "Galinhos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3728,
					Name = "Goianinha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3729,
					Name = "Governador Dix-Sept Rosado",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3730,
					Name = "Grossos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3731,
					Name = "Guamaré",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3732,
					Name = "Ielmo Marinho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3733,
					Name = "Ipanguaçu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3734,
					Name = "Ipueira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3735,
					Name = "Itajá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3736,
					Name = "Itaú",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3737,
					Name = "Jaçanã",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3738,
					Name = "Jandaíra",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3739,
					Name = "Janduís",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3740,
					Name = "Januário Cicco",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3741,
					Name = "Japi",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3742,
					Name = "Jardim de Angicos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3743,
					Name = "Jardim de Piranhas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3744,
					Name = "Jardim do Seridó",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3745,
					Name = "João Câmara",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3746,
					Name = "João Dias",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3747,
					Name = "José da Penha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3748,
					Name = "Jucurutu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3749,
					Name = "Jundiá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3750,
					Name = "Lagoa d`Anta",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3751,
					Name = "Lagoa de Pedras",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3752,
					Name = "Lagoa de Velhos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3753,
					Name = "Lagoa Nova",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3754,
					Name = "Lagoa Salgada",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3755,
					Name = "Lajes",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3756,
					Name = "Lajes Pintadas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3757,
					Name = "Lucrécia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3758,
					Name = "Luís Gomes",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3759,
					Name = "Macaíba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3760,
					Name = "Macau",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3761,
					Name = "Major Sales",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3762,
					Name = "Marcelino Vieira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3763,
					Name = "Martins",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3764,
					Name = "Maxaranguape",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3765,
					Name = "Messias Targino",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3766,
					Name = "Montanhas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3767,
					Name = "Monte Alegre",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3768,
					Name = "Monte das Gameleiras",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3769,
					Name = "Mossoró",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3770,
					Name = "Natal",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3771,
					Name = "Nísia Floresta",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3772,
					Name = "Nova Cruz",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3773,
					Name = "Olho-d`Água do Borges",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3774,
					Name = "Ouro Branco",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3775,
					Name = "Paraná",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3776,
					Name = "Paraú",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3777,
					Name = "Parazinho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3778,
					Name = "Parelhas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3779,
					Name = "Parnamirim",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3780,
					Name = "Passa e Fica",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3781,
					Name = "Passagem",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3782,
					Name = "Patu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3783,
					Name = "Pau dos Ferros",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3784,
					Name = "Pedra Grande",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3785,
					Name = "Pedra Preta",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3786,
					Name = "Pedro Avelino",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3787,
					Name = "Pedro Velho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3788,
					Name = "Pendências",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3789,
					Name = "Pilões",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3790,
					Name = "Poço Branco",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3791,
					Name = "Portalegre",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3792,
					Name = "Porto do Mangue",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3793,
					Name = "Presidente Juscelino",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3794,
					Name = "Pureza",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3795,
					Name = "Rafael Fernandes",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3796,
					Name = "Rafael Godeiro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3797,
					Name = "Riacho da Cruz",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3798,
					Name = "Riacho de Santana",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3799,
					Name = "Riachuelo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3800,
					Name = "Rio do Fogo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3801,
					Name = "Rodolfo Fernandes",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3802,
					Name = "Ruy Barbosa",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3803,
					Name = "Santa Cruz",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3804,
					Name = "Santa Maria",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3805,
					Name = "Santana do Matos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3806,
					Name = "Santana do Seridó",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3807,
					Name = "Santo Antônio",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3808,
					Name = "São Bento do Norte",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3809,
					Name = "São Bento do Trairí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3810,
					Name = "São Fernando",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3811,
					Name = "São Francisco do Oeste",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3812,
					Name = "São Gonçalo do Amarante",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3813,
					Name = "São João do Sabugi",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3814,
					Name = "São José de Mipibu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3815,
					Name = "São José do Campestre",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3816,
					Name = "São José do Seridó",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3817,
					Name = "São Miguel",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3818,
					Name = "São Miguel do Gostoso",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3819,
					Name = "São Paulo do Potengi",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3820,
					Name = "São Pedro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3821,
					Name = "São Rafael",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3822,
					Name = "São Tomé",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3823,
					Name = "São Vicente",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3824,
					Name = "Senador Elói de Souza",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3825,
					Name = "Senador Georgino Avelino",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3826,
					Name = "Serra de São Bento",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3827,
					Name = "Serra do Mel",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3828,
					Name = "Serra Negra do Norte",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3829,
					Name = "Serrinha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3830,
					Name = "Serrinha dos Pintos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3831,
					Name = "Severiano Melo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3832,
					Name = "Sítio Novo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3833,
					Name = "Taboleiro Grande",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3834,
					Name = "Taipu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3835,
					Name = "Tangará",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3836,
					Name = "Tenente Ananias",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3837,
					Name = "Tenente Laurentino Cruz",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3838,
					Name = "Tibau",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3839,
					Name = "Tibau do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3840,
					Name = "Timbaúba dos Batistas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3841,
					Name = "Touros",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3842,
					Name = "Triunfo Potiguar",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3843,
					Name = "Umarizal",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3844,
					Name = "Upanema",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3845,
					Name = "Várzea",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3846,
					Name = "Venha-Ver",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3847,
					Name = "Vera Cruz",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3848,
					Name = "Viçosa",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3849,
					Name = "Vila Flor",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3850,
					Name = "Aceguá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3851,
					Name = "Água Santa",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3852,
					Name = "Agudo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3853,
					Name = "Ajuricaba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3854,
					Name = "Alecrim",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3855,
					Name = "Alegrete",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3856,
					Name = "Alegria",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3857,
					Name = "Almirante Tamandaré do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3858,
					Name = "Alpestre",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3859,
					Name = "Alto Alegre",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3860,
					Name = "Alto Feliz",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3861,
					Name = "Alvorada",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3862,
					Name = "Amaral Ferrador",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3863,
					Name = "Ametista do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3864,
					Name = "André da Rocha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3865,
					Name = "Anta Gorda",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3866,
					Name = "Antônio Prado",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3867,
					Name = "Arambaré",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3868,
					Name = "Araricá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3869,
					Name = "Aratiba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3870,
					Name = "Arroio do Meio",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3871,
					Name = "Arroio do Padre",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3872,
					Name = "Arroio do Sal",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3873,
					Name = "Arroio do Tigre",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3874,
					Name = "Arroio dos Ratos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3875,
					Name = "Arroio Grande",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3876,
					Name = "Arvorezinha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3877,
					Name = "Augusto Pestana",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3878,
					Name = "Áurea",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3879,
					Name = "Bagé",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3880,
					Name = "Balneário Pinhal",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3881,
					Name = "Barão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3882,
					Name = "Barão de Cotegipe",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3883,
					Name = "Barão do Triunfo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3884,
					Name = "Barra do Guarita",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3885,
					Name = "Barra do Quaraí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3886,
					Name = "Barra do Ribeiro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3887,
					Name = "Barra do Rio Azul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3888,
					Name = "Barra Funda",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3889,
					Name = "Barracão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3890,
					Name = "Barros Cassal",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3891,
					Name = "Benjamin Constant do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3892,
					Name = "Bento Gonçalves",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3893,
					Name = "Boa Vista das Missões",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3894,
					Name = "Boa Vista do Buricá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3895,
					Name = "Boa Vista do Cadeado",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3896,
					Name = "Boa Vista do Incra",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3897,
					Name = "Boa Vista do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3898,
					Name = "Bom Jesus",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3899,
					Name = "Bom Princípio",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3900,
					Name = "Bom Progresso",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3901,
					Name = "Bom Retiro do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3902,
					Name = "Boqueirão do Leão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3903,
					Name = "Bossoroca",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3904,
					Name = "Bozano",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3905,
					Name = "Braga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3906,
					Name = "Brochier",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3907,
					Name = "Butiá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3908,
					Name = "Caçapava do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3909,
					Name = "Cacequi",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3910,
					Name = "Cachoeira do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3911,
					Name = "Cachoeirinha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3912,
					Name = "Cacique Doble",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3913,
					Name = "Caibaté",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3914,
					Name = "Caiçara",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3915,
					Name = "Camaquã",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3916,
					Name = "Camargo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3917,
					Name = "Cambará do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3918,
					Name = "Campestre da Serra",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3919,
					Name = "Campina das Missões",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3920,
					Name = "Campinas do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3921,
					Name = "Campo Bom",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3922,
					Name = "Campo Novo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3923,
					Name = "Campos Borges",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3924,
					Name = "Candelária",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3925,
					Name = "Cândido Godói",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3926,
					Name = "Candiota",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3927,
					Name = "Canela",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3928,
					Name = "Canguçu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3929,
					Name = "Canoas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3930,
					Name = "Canudos do Vale",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3931,
					Name = "Capão Bonito do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3932,
					Name = "Capão da Canoa",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3933,
					Name = "Capão do Cipó",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3934,
					Name = "Capão do Leão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3935,
					Name = "Capela de Santana",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3936,
					Name = "Capitão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3937,
					Name = "Capivari do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3938,
					Name = "Caraá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3939,
					Name = "Carazinho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3940,
					Name = "Carlos Barbosa",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3941,
					Name = "Carlos Gomes",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3942,
					Name = "Casca",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3943,
					Name = "Caseiros",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3944,
					Name = "Catuípe",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3945,
					Name = "Caxias do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3946,
					Name = "Centenário",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3947,
					Name = "Cerrito",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3948,
					Name = "Cerro Branco",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3949,
					Name = "Cerro Grande",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3950,
					Name = "Cerro Grande do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3951,
					Name = "Cerro Largo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3952,
					Name = "Chapada",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3953,
					Name = "Charqueadas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3954,
					Name = "Charrua",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3955,
					Name = "Chiapeta",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3956,
					Name = "Chuí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3957,
					Name = "Chuvisca",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3958,
					Name = "Cidreira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3959,
					Name = "Ciríaco",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3960,
					Name = "Colinas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3961,
					Name = "Colorado",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3962,
					Name = "Condor",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3963,
					Name = "Constantina",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3964,
					Name = "Coqueiro Baixo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3965,
					Name = "Coqueiros do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3966,
					Name = "Coronel Barros",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3967,
					Name = "Coronel Bicaco",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3968,
					Name = "Coronel Pilar",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3969,
					Name = "Cotiporã",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3970,
					Name = "Coxilha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3971,
					Name = "Crissiumal",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3972,
					Name = "Cristal",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3973,
					Name = "Cristal do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3974,
					Name = "Cruz Alta",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3975,
					Name = "Cruzaltense",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3976,
					Name = "Cruzeiro do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3977,
					Name = "David Canabarro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3978,
					Name = "Derrubadas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3979,
					Name = "Dezesseis de Novembro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3980,
					Name = "Dilermando de Aguiar",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3981,
					Name = "Dois Irmãos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3982,
					Name = "Dois Irmãos das Missões",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3983,
					Name = "Dois Lajeados",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3984,
					Name = "Dom Feliciano",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3985,
					Name = "Dom Pedrito",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3986,
					Name = "Dom Pedro de Alcântara",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3987,
					Name = "Dona Francisca",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3988,
					Name = "Doutor Maurício Cardoso",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3989,
					Name = "Doutor Ricardo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3990,
					Name = "Eldorado do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3991,
					Name = "Encantado",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3992,
					Name = "Encruzilhada do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3993,
					Name = "Engenho Velho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3994,
					Name = "Entre Rios do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3995,
					Name = "Entre-Ijuís",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3996,
					Name = "Erebango",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3997,
					Name = "Erechim",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3998,
					Name = "Ernestina",
					Active = false,
				},
				new CityEntity()
		{
			Id = 3999,
					Name = "Erval Grande",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4000,
					Name = "Erval Seco",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4001,
					Name = "Esmeralda",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4002,
					Name = "Esperança do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4003,
					Name = "Espumoso",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4004,
					Name = "Estação",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4005,
					Name = "Estância Velha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4006,
					Name = "Esteio",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4007,
					Name = "Estrela",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4008,
					Name = "Estrela Velha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4009,
					Name = "Eugênio de Castro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4010,
					Name = "Fagundes Varela",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4011,
					Name = "Farroupilha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4012,
					Name = "Faxinal do Soturno",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4013,
					Name = "Faxinalzinho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4014,
					Name = "Fazenda Vilanova",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4015,
					Name = "Feliz",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4016,
					Name = "Flores da Cunha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4017,
					Name = "Floriano Peixoto",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4018,
					Name = "Fontoura Xavier",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4019,
					Name = "Formigueiro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4020,
					Name = "Forquetinha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4021,
					Name = "Fortaleza dos Valos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4022,
					Name = "Frederico Westphalen",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4023,
					Name = "Garibaldi",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4024,
					Name = "Garruchos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4025,
					Name = "Gaurama",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4026,
					Name = "General Câmara",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4027,
					Name = "Gentil",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4028,
					Name = "Getúlio Vargas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4029,
					Name = "Giruá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4030,
					Name = "Glorinha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4031,
					Name = "Gramado",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4032,
					Name = "Gramado dos Loureiros",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4033,
					Name = "Gramado Xavier",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4034,
					Name = "Gravataí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4035,
					Name = "Guabiju",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4036,
					Name = "Guaíba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4037,
					Name = "Guaporé",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4038,
					Name = "Guarani das Missões",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4039,
					Name = "Harmonia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4040,
					Name = "Herval",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4041,
					Name = "Herveiras",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4042,
					Name = "Horizontina",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4043,
					Name = "Hulha Negra",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4044,
					Name = "Humaitá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4045,
					Name = "Ibarama",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4046,
					Name = "Ibiaçá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4047,
					Name = "Ibiraiaras",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4048,
					Name = "Ibirapuitã",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4049,
					Name = "Ibirubá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4050,
					Name = "Igrejinha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4051,
					Name = "Ijuí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4052,
					Name = "Ilópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4053,
					Name = "Imbé",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4054,
					Name = "Imigrante",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4055,
					Name = "Independência",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4056,
					Name = "Inhacorá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4057,
					Name = "Ipê",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4058,
					Name = "Ipiranga do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4059,
					Name = "Iraí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4060,
					Name = "Itaara",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4061,
					Name = "Itacurubi",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4062,
					Name = "Itapuca",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4063,
					Name = "Itaqui",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4064,
					Name = "Itati",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4065,
					Name = "Itatiba do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4066,
					Name = "Ivorá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4067,
					Name = "Ivoti",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4068,
					Name = "Jaboticaba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4069,
					Name = "Jacuizinho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4070,
					Name = "Jacutinga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4071,
					Name = "Jaguarão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4072,
					Name = "Jaguari",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4073,
					Name = "Jaquirana",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4074,
					Name = "Jari",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4075,
					Name = "Jóia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4076,
					Name = "Júlio de Castilhos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4077,
					Name = "Lagoa Bonita do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4078,
					Name = "Lagoa dos Três Cantos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4079,
					Name = "Lagoa Vermelha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4080,
					Name = "Lagoão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4081,
					Name = "Lajeado",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4082,
					Name = "Lajeado do Bugre",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4083,
					Name = "Lavras do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4084,
					Name = "Liberato Salzano",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4085,
					Name = "Lindolfo Collor",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4086,
					Name = "Linha Nova",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4087,
					Name = "Maçambara",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4088,
					Name = "Machadinho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4089,
					Name = "Mampituba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4090,
					Name = "Manoel Viana",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4091,
					Name = "Maquiné",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4092,
					Name = "Maratá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4093,
					Name = "Marau",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4094,
					Name = "Marcelino Ramos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4095,
					Name = "Mariana Pimentel",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4096,
					Name = "Mariano Moro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4097,
					Name = "Marques de Souza",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4098,
					Name = "Mata",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4099,
					Name = "Mato Castelhano",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4100,
					Name = "Mato Leitão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4101,
					Name = "Mato Queimado",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4102,
					Name = "Maximiliano de Almeida",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4103,
					Name = "Minas do Leão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4104,
					Name = "Miraguaí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4105,
					Name = "Montauri",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4106,
					Name = "Monte Alegre dos Campos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4107,
					Name = "Monte Belo do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4108,
					Name = "Montenegro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4109,
					Name = "Mormaço",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4110,
					Name = "Morrinhos do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4111,
					Name = "Morro Redondo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4112,
					Name = "Morro Reuter",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4113,
					Name = "Mostardas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4114,
					Name = "Muçum",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4115,
					Name = "Muitos Capões",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4116,
					Name = "Muliterno",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4117,
					Name = "Não-Me-Toque",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4118,
					Name = "Nicolau Vergueiro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4119,
					Name = "Nonoai",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4120,
					Name = "Nova Alvorada",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4121,
					Name = "Nova Araçá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4122,
					Name = "Nova Bassano",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4123,
					Name = "Nova Boa Vista",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4124,
					Name = "Nova Bréscia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4125,
					Name = "Nova Candelária",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4126,
					Name = "Nova Esperança do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4127,
					Name = "Nova Hartz",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4128,
					Name = "Nova Pádua",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4129,
					Name = "Nova Palma",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4130,
					Name = "Nova Petrópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4131,
					Name = "Nova Prata",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4132,
					Name = "Nova Ramada",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4133,
					Name = "Nova Roma do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4134,
					Name = "Nova Santa Rita",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4135,
					Name = "Novo Barreiro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4136,
					Name = "Novo Cabrais",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4137,
					Name = "Novo Hamburgo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4138,
					Name = "Novo Machado",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4139,
					Name = "Novo Tiradentes",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4140,
					Name = "Novo Xingu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4141,
					Name = "Osório",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4142,
					Name = "Paim Filho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4143,
					Name = "Palmares do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4144,
					Name = "Palmeira das Missões",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4145,
					Name = "Palmitinho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4146,
					Name = "Panambi",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4147,
					Name = "Pantano Grande",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4148,
					Name = "Paraí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4149,
					Name = "Paraíso do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4150,
					Name = "Pareci Novo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4151,
					Name = "Parobé",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4152,
					Name = "Passa Sete",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4153,
					Name = "Passo do Sobrado",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4154,
					Name = "Passo Fundo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4155,
					Name = "Paulo Bento",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4156,
					Name = "Paverama",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4157,
					Name = "Pedras Altas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4158,
					Name = "Pedro Osório",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4159,
					Name = "Pejuçara",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4160,
					Name = "Pelotas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4161,
					Name = "Picada Café",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4162,
					Name = "Pinhal",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4163,
					Name = "Pinhal da Serra",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4164,
					Name = "Pinhal Grande",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4165,
					Name = "Pinheirinho do Vale",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4166,
					Name = "Pinheiro Machado",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4167,
					Name = "Pirapó",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4168,
					Name = "Piratini",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4169,
					Name = "Planalto",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4170,
					Name = "Poço das Antas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4171,
					Name = "Pontão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4172,
					Name = "Ponte Preta",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4173,
					Name = "Portão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4174,
					Name = "Porto Alegre",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4175,
					Name = "Porto Lucena",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4176,
					Name = "Porto Mauá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4177,
					Name = "Porto Vera Cruz",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4178,
					Name = "Porto Xavier",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4179,
					Name = "Pouso Novo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4180,
					Name = "Presidente Lucena",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4181,
					Name = "Progresso",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4182,
					Name = "Protásio Alves",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4183,
					Name = "Putinga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4184,
					Name = "Quaraí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4185,
					Name = "Quatro Irmãos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4186,
					Name = "Quevedos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4187,
					Name = "Quinze de Novembro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4188,
					Name = "Redentora",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4189,
					Name = "Relvado",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4190,
					Name = "Restinga Seca",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4191,
					Name = "Rio dos Índios",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4192,
					Name = "Rio Grande",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4193,
					Name = "Rio Pardo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4194,
					Name = "Riozinho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4195,
					Name = "Roca Sales",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4196,
					Name = "Rodeio Bonito",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4197,
					Name = "Rolador",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4198,
					Name = "Rolante",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4199,
					Name = "Ronda Alta",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4200,
					Name = "Rondinha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4201,
					Name = "Roque Gonzales",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4202,
					Name = "Rosário do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4203,
					Name = "Sagrada Família",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4204,
					Name = "Saldanha Marinho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4205,
					Name = "Salto do Jacuí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4206,
					Name = "Salvador das Missões",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4207,
					Name = "Salvador do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4208,
					Name = "Sananduva",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4209,
					Name = "Santa Bárbara do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4210,
					Name = "Santa Cecília do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4211,
					Name = "Santa Clara do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4212,
					Name = "Santa Cruz do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4213,
					Name = "Santa Margarida do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4214,
					Name = "Santa Maria",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4215,
					Name = "Santa Maria do Herval",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4216,
					Name = "Santa Rosa",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4217,
					Name = "Santa Tereza",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4218,
					Name = "Santa Vitória do Palmar",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4219,
					Name = "Santana da Boa Vista",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4220,
					Name = "Santana do Livramento",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4221,
					Name = "Santiago",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4222,
					Name = "Santo Ângelo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4223,
					Name = "Santo Antônio da Patrulha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4224,
					Name = "Santo Antônio das Missões",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4225,
					Name = "Santo Antônio do Palma",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4226,
					Name = "Santo Antônio do Planalto",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4227,
					Name = "Santo Augusto",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4228,
					Name = "Santo Cristo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4229,
					Name = "Santo Expedito do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4230,
					Name = "São Borja",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4231,
					Name = "São Domingos do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4232,
					Name = "São Francisco de Assis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4233,
					Name = "São Francisco de Paula",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4234,
					Name = "São Gabriel",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4235,
					Name = "São Jerônimo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4236,
					Name = "São João da Urtiga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4237,
					Name = "São João do Polêsine",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4238,
					Name = "São Jorge",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4239,
					Name = "São José das Missões",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4240,
					Name = "São José do Herval",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4241,
					Name = "São José do Hortêncio",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4242,
					Name = "São José do Inhacorá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4243,
					Name = "São José do Norte",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4244,
					Name = "São José do Ouro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4245,
					Name = "São José do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4246,
					Name = "São José dos Ausentes",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4247,
					Name = "São Leopoldo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4248,
					Name = "São Lourenço do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4249,
					Name = "São Luiz Gonzaga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4250,
					Name = "São Marcos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4251,
					Name = "São Martinho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4252,
					Name = "São Martinho da Serra",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4253,
					Name = "São Miguel das Missões",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4254,
					Name = "São Nicolau",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4255,
					Name = "São Paulo das Missões",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4256,
					Name = "São Pedro da Serra",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4257,
					Name = "São Pedro das Missões",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4258,
					Name = "São Pedro do Butiá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4259,
					Name = "São Pedro do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4260,
					Name = "São Sebastião do Caí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4261,
					Name = "São Sepé",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4262,
					Name = "São Valentim",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4263,
					Name = "São Valentim do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4264,
					Name = "São Valério do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4265,
					Name = "São Vendelino",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4266,
					Name = "São Vicente do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4267,
					Name = "Sapiranga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4268,
					Name = "Sapucaia do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4269,
					Name = "Sarandi",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4270,
					Name = "Seberi",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4271,
					Name = "Sede Nova",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4272,
					Name = "Segredo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4273,
					Name = "Selbach",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4274,
					Name = "Senador Salgado Filho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4275,
					Name = "Sentinela do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4276,
					Name = "Serafina Corrêa",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4277,
					Name = "Sério",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4278,
					Name = "Sertão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4279,
					Name = "Sertão Santana",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4280,
					Name = "Sete de Setembro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4281,
					Name = "Severiano de Almeida",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4282,
					Name = "Silveira Martins",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4283,
					Name = "Sinimbu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4284,
					Name = "Sobradinho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4285,
					Name = "Soledade",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4286,
					Name = "Tabaí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4287,
					Name = "Tapejara",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4288,
					Name = "Tapera",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4289,
					Name = "Tapes",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4290,
					Name = "Taquara",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4291,
					Name = "Taquari",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4292,
					Name = "Taquaruçu do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4293,
					Name = "Tavares",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4294,
					Name = "Tenente Portela",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4295,
					Name = "Terra de Areia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4296,
					Name = "Teutônia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4297,
					Name = "Tio Hugo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4298,
					Name = "Tiradentes do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4299,
					Name = "Toropi",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4300,
					Name = "Torres",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4301,
					Name = "Tramandaí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4302,
					Name = "Travesseiro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4303,
					Name = "Três Arroios",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4304,
					Name = "Três Cachoeiras",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4305,
					Name = "Três Coroas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4306,
					Name = "Três de Maio",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4307,
					Name = "Três Forquilhas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4308,
					Name = "Três Palmeiras",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4309,
					Name = "Três Passos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4310,
					Name = "Trindade do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4311,
					Name = "Triunfo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4312,
					Name = "Tucunduva",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4313,
					Name = "Tunas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4314,
					Name = "Tupanci do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4315,
					Name = "Tupanciretã",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4316,
					Name = "Tupandi",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4317,
					Name = "Tuparendi",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4318,
					Name = "Turuçu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4319,
					Name = "Ubiretama",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4320,
					Name = "União da Serra",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4321,
					Name = "Unistalda",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4322,
					Name = "Uruguaiana",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4323,
					Name = "Vacaria",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4324,
					Name = "Vale do Sol",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4325,
					Name = "Vale Real",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4326,
					Name = "Vale Verde",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4327,
					Name = "Vanini",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4328,
					Name = "Venâncio Aires",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4329,
					Name = "Vera Cruz",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4330,
					Name = "Veranópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4331,
					Name = "Vespasiano Correa",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4332,
					Name = "Viadutos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4333,
					Name = "Viamão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4334,
					Name = "Vicente Dutra",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4335,
					Name = "Victor Graeff",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4336,
					Name = "Vila Flores",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4337,
					Name = "Vila Lângaro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4338,
					Name = "Vila Maria",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4339,
					Name = "Vila Nova do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4340,
					Name = "Vista Alegre",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4341,
					Name = "Vista Alegre do Prata",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4342,
					Name = "Vista Gaúcha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4343,
					Name = "Vitória das Missões",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4344,
					Name = "Westfália",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4345,
					Name = "Xangri-lá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4346,
					Name = "Alta Floresta d`Oeste",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4347,
					Name = "Alto Alegre dos Parecis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4348,
					Name = "Alto Paraíso",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4349,
					Name = "Alvorada d`Oeste",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4350,
					Name = "Ariquemes",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4351,
					Name = "Buritis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4352,
					Name = "Cabixi",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4353,
					Name = "Cacaulândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4354,
					Name = "Cacoal",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4355,
					Name = "Campo Novo de Rondônia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4356,
					Name = "Candeias do Jamari",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4357,
					Name = "Castanheiras",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4358,
					Name = "Cerejeiras",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4359,
					Name = "Chupinguaia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4360,
					Name = "Colorado do Oeste",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4361,
					Name = "Corumbiara",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4362,
					Name = "Costa Marques",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4363,
					Name = "Cujubim",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4364,
					Name = "Espigão d`Oeste",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4365,
					Name = "Governador Jorge Teixeira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4366,
					Name = "Guajará-Mirim",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4367,
					Name = "Itapuã do Oeste",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4368,
					Name = "Jaru",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4369,
					Name = "Ji-Paraná",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4370,
					Name = "Machadinho d`Oeste",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4371,
					Name = "Ministro Andreazza",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4372,
					Name = "Mirante da Serra",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4373,
					Name = "Monte Negro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4374,
					Name = "Nova Brasilândia d`Oeste",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4375,
					Name = "Nova Mamoré",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4376,
					Name = "Nova União",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4377,
					Name = "Novo Horizonte do Oeste",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4378,
					Name = "Ouro Preto do Oeste",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4379,
					Name = "Parecis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4380,
					Name = "Pimenta Bueno",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4381,
					Name = "Pimenteiras do Oeste",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4382,
					Name = "Porto Velho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4383,
					Name = "Presidente Médici",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4384,
					Name = "Primavera de Rondônia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4385,
					Name = "Rio Crespo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4386,
					Name = "Rolim de Moura",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4387,
					Name = "Santa Luzia d`Oeste",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4388,
					Name = "São Felipe d`Oeste",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4389,
					Name = "São Francisco do Guaporé",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4390,
					Name = "São Miguel do Guaporé",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4391,
					Name = "Seringueiras",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4392,
					Name = "Teixeirópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4393,
					Name = "Theobroma",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4394,
					Name = "Urupá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4395,
					Name = "Vale do Anari",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4396,
					Name = "Vale do Paraíso",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4397,
					Name = "Vilhena",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4398,
					Name = "Alto Alegre",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4399,
					Name = "Amajari",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4400,
					Name = "Boa Vista",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4401,
					Name = "Bonfim",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4402,
					Name = "Cantá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4403,
					Name = "Caracaraí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4404,
					Name = "Caroebe",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4405,
					Name = "Iracema",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4406,
					Name = "Mucajaí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4407,
					Name = "Normandia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4408,
					Name = "Pacaraima",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4409,
					Name = "Rorainópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4410,
					Name = "São João da Baliza",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4411,
					Name = "São Luiz",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4412,
					Name = "Uiramutã",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4413,
					Name = "Abdon Batista",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4414,
					Name = "Abelardo Luz",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4415,
					Name = "Agrolândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4416,
					Name = "Agronômica",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4417,
					Name = "Água Doce",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4418,
					Name = "Águas de Chapecó",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4419,
					Name = "Águas Frias",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4420,
					Name = "Águas Mornas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4421,
					Name = "Alfredo Wagner",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4422,
					Name = "Alto Bela Vista",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4423,
					Name = "Anchieta",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4424,
					Name = "Angelina",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4425,
					Name = "Anita Garibaldi",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4426,
					Name = "Anitápolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4427,
					Name = "Antônio Carlos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4428,
					Name = "Apiúna",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4429,
					Name = "Arabutã",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4430,
					Name = "Araquari",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4431,
					Name = "Araranguá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4432,
					Name = "Armazém",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4433,
					Name = "Arroio Trinta",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4434,
					Name = "Arvoredo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4435,
					Name = "Ascurra",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4436,
					Name = "Atalanta",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4437,
					Name = "Aurora",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4438,
					Name = "Balneário Arroio do Silva",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4439,
					Name = "Balneário Barra do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4440,
					Name = "Balneário Camboriú",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4441,
					Name = "Balneário Gaivota",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4442,
					Name = "Bandeirante",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4443,
					Name = "Barra Bonita",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4444,
					Name = "Barra Velha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4445,
					Name = "Bela Vista do Toldo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4446,
					Name = "Belmonte",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4447,
					Name = "Benedito Novo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4448,
					Name = "Biguaçu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4449,
					Name = "Blumenau",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4450,
					Name = "Bocaina do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4451,
					Name = "Bom Jardim da Serra",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4452,
					Name = "Bom Jesus",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4453,
					Name = "Bom Jesus do Oeste",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4454,
					Name = "Bom Retiro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4455,
					Name = "Bombinhas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4456,
					Name = "Botuverá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4457,
					Name = "Braço do Norte",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4458,
					Name = "Braço do Trombudo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4459,
					Name = "Brunópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4460,
					Name = "Brusque",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4461,
					Name = "Caçador",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4462,
					Name = "Caibi",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4463,
					Name = "Calmon",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4464,
					Name = "Camboriú",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4465,
					Name = "Campo Alegre",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4466,
					Name = "Campo Belo do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4467,
					Name = "Campo Erê",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4468,
					Name = "Campos Novos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4469,
					Name = "Canelinha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4470,
					Name = "Canoinhas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4471,
					Name = "Capão Alto",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4472,
					Name = "Capinzal",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4473,
					Name = "Capivari de Baixo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4474,
					Name = "Catanduvas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4475,
					Name = "Caxambu do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4476,
					Name = "Celso Ramos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4477,
					Name = "Cerro Negro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4478,
					Name = "Chapadão do Lageado",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4479,
					Name = "Chapecó",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4480,
					Name = "Cocal do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4481,
					Name = "Concórdia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4482,
					Name = "Cordilheira Alta",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4483,
					Name = "Coronel Freitas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4484,
					Name = "Coronel Martins",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4485,
					Name = "Correia Pinto",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4486,
					Name = "Corupá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4487,
					Name = "Criciúma",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4488,
					Name = "Cunha Porã",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4489,
					Name = "Cunhataí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4490,
					Name = "Curitibanos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4491,
					Name = "Descanso",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4492,
					Name = "Dionísio Cerqueira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4493,
					Name = "Dona Emma",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4494,
					Name = "Doutor Pedrinho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4495,
					Name = "Entre Rios",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4496,
					Name = "Ermo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4497,
					Name = "Erval Velho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4498,
					Name = "Faxinal dos Guedes",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4499,
					Name = "Flor do Sertão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4500,
					Name = "Florianópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4501,
					Name = "Formosa do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4502,
					Name = "Forquilhinha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4503,
					Name = "Fraiburgo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4504,
					Name = "Frei Rogério",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4505,
					Name = "Galvão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4506,
					Name = "Garopaba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4507,
					Name = "Garuva",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4508,
					Name = "Gaspar",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4509,
					Name = "Governador Celso Ramos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4510,
					Name = "Grão Pará",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4511,
					Name = "Gravatal",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4512,
					Name = "Guabiruba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4513,
					Name = "Guaraciaba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4514,
					Name = "Guaramirim",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4515,
					Name = "Guarujá do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4516,
					Name = "Guatambú",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4517,
					Name = "Herval d`Oeste",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4518,
					Name = "Ibiam",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4519,
					Name = "Ibicaré",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4520,
					Name = "Ibirama",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4521,
					Name = "Içara",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4522,
					Name = "Ilhota",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4523,
					Name = "Imaruí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4524,
					Name = "Imbituba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4525,
					Name = "Imbuia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4526,
					Name = "Indaial",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4527,
					Name = "Iomerê",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4528,
					Name = "Ipira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4529,
					Name = "Iporã do Oeste",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4530,
					Name = "Ipuaçu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4531,
					Name = "Ipumirim",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4532,
					Name = "Iraceminha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4533,
					Name = "Irani",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4534,
					Name = "Irati",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4535,
					Name = "Irineópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4536,
					Name = "Itá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4537,
					Name = "Itaiópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4538,
					Name = "Itajaí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4539,
					Name = "Itapema",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4540,
					Name = "Itapiranga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4541,
					Name = "Itapoá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4542,
					Name = "Ituporanga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4543,
					Name = "Jaborá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4544,
					Name = "Jacinto Machado",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4545,
					Name = "Jaguaruna",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4546,
					Name = "Jaraguá do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4547,
					Name = "Jardinópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4548,
					Name = "Joaçaba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4549,
					Name = "Joinville",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4550,
					Name = "José Boiteux",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4551,
					Name = "Jupiá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4552,
					Name = "Lacerdópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4553,
					Name = "Lages",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4554,
					Name = "Laguna",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4555,
					Name = "Lajeado Grande",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4556,
					Name = "Laurentino",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4557,
					Name = "Lauro Muller",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4558,
					Name = "Lebon Régis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4559,
					Name = "Leoberto Leal",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4560,
					Name = "Lindóia do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4561,
					Name = "Lontras",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4562,
					Name = "Luiz Alves",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4563,
					Name = "Luzerna",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4564,
					Name = "Macieira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4565,
					Name = "Mafra",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4566,
					Name = "Major Gercino",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4567,
					Name = "Major Vieira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4568,
					Name = "Maracajá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4569,
					Name = "Maravilha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4570,
					Name = "Marema",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4571,
					Name = "Massaranduba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4572,
					Name = "Matos Costa",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4573,
					Name = "Meleiro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4574,
					Name = "Mirim Doce",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4575,
					Name = "Modelo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4576,
					Name = "Mondaí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4577,
					Name = "Monte Carlo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4578,
					Name = "Monte Castelo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4579,
					Name = "Morro da Fumaça",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4580,
					Name = "Morro Grande",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4581,
					Name = "Navegantes",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4582,
					Name = "Nova Erechim",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4583,
					Name = "Nova Itaberaba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4584,
					Name = "Nova Trento",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4585,
					Name = "Nova Veneza",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4586,
					Name = "Novo Horizonte",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4587,
					Name = "Orleans",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4588,
					Name = "Otacílio Costa",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4589,
					Name = "Ouro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4590,
					Name = "Ouro Verde",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4591,
					Name = "Paial",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4592,
					Name = "Painel",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4593,
					Name = "Palhoça",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4594,
					Name = "Palma Sola",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4595,
					Name = "Palmeira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4596,
					Name = "Palmitos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4597,
					Name = "Papanduva",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4598,
					Name = "Paraíso",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4599,
					Name = "Passo de Torres",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4600,
					Name = "Passos Maia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4601,
					Name = "Paulo Lopes",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4602,
					Name = "Pedras Grandes",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4603,
					Name = "Penha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4604,
					Name = "Peritiba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4605,
					Name = "Petrolândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4606,
					Name = "Piçarras",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4607,
					Name = "Pinhalzinho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4608,
					Name = "Pinheiro Preto",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4609,
					Name = "Piratuba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4610,
					Name = "Planalto Alegre",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4611,
					Name = "Pomerode",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4612,
					Name = "Ponte Alta",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4613,
					Name = "Ponte Alta do Norte",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4614,
					Name = "Ponte Serrada",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4615,
					Name = "Porto Belo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4616,
					Name = "Porto União",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4617,
					Name = "Pouso Redondo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4618,
					Name = "Praia Grande",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4619,
					Name = "Presidente Castelo Branco",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4620,
					Name = "Presidente Getúlio",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4621,
					Name = "Presidente Nereu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4622,
					Name = "Princesa",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4623,
					Name = "Quilombo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4624,
					Name = "Rancho Queimado",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4625,
					Name = "Rio das Antas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4626,
					Name = "Rio do Campo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4627,
					Name = "Rio do Oeste",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4628,
					Name = "Rio do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4629,
					Name = "Rio dos Cedros",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4630,
					Name = "Rio Fortuna",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4631,
					Name = "Rio Negrinho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4632,
					Name = "Rio Rufino",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4633,
					Name = "Riqueza",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4634,
					Name = "Rodeio",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4635,
					Name = "Romelândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4636,
					Name = "Salete",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4637,
					Name = "Saltinho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4638,
					Name = "Salto Veloso",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4639,
					Name = "Sangão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4640,
					Name = "Santa Cecília",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4641,
					Name = "Santa Helena",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4642,
					Name = "Santa Rosa de Lima",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4643,
					Name = "Santa Rosa do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4644,
					Name = "Santa Terezinha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4645,
					Name = "Santa Terezinha do Progresso",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4646,
					Name = "Santiago do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4647,
					Name = "Santo Amaro da Imperatriz",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4648,
					Name = "São Bento do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4649,
					Name = "São Bernardino",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4650,
					Name = "São Bonifácio",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4651,
					Name = "São Carlos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4652,
					Name = "São Cristovão do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4653,
					Name = "São Domingos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4654,
					Name = "São Francisco do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4655,
					Name = "São João Batista",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4656,
					Name = "São João do Itaperiú",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4657,
					Name = "São João do Oeste",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4658,
					Name = "São João do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4659,
					Name = "São Joaquim",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4660,
					Name = "São José",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4661,
					Name = "São José do Cedro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4662,
					Name = "São José do Cerrito",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4663,
					Name = "São Lourenço do Oeste",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4664,
					Name = "São Ludgero",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4665,
					Name = "São Martinho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4666,
					Name = "São Miguel da Boa Vista",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4667,
					Name = "São Miguel do Oeste",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4668,
					Name = "São Pedro de Alcântara",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4669,
					Name = "Saudades",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4670,
					Name = "Schroeder",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4671,
					Name = "Seara",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4672,
					Name = "Serra Alta",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4673,
					Name = "Siderópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4674,
					Name = "Sombrio",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4675,
					Name = "Sul Brasil",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4676,
					Name = "Taió",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4677,
					Name = "Tangará",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4678,
					Name = "Tigrinhos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4679,
					Name = "Tijucas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4680,
					Name = "Timbé do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4681,
					Name = "Timbó",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4682,
					Name = "Timbó Grande",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4683,
					Name = "Três Barras",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4684,
					Name = "Treviso",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4685,
					Name = "Treze de Maio",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4686,
					Name = "Treze Tílias",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4687,
					Name = "Trombudo Central",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4688,
					Name = "Tubarão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4689,
					Name = "Tunápolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4690,
					Name = "Turvo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4691,
					Name = "União do Oeste",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4692,
					Name = "Urubici",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4693,
					Name = "Urupema",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4694,
					Name = "Urussanga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4695,
					Name = "Vargeão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4696,
					Name = "Vargem",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4697,
					Name = "Vargem Bonita",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4698,
					Name = "Vidal Ramos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4699,
					Name = "Videira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4700,
					Name = "Vitor Meireles",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4701,
					Name = "Witmarsum",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4702,
					Name = "Xanxerê",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4703,
					Name = "Xavantina",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4704,
					Name = "Xaxim",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4705,
					Name = "Zortéa",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4706,
					Name = "Adamantina",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4707,
					Name = "Adolfo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4708,
					Name = "Aguaí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4709,
					Name = "Águas da Prata",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4710,
					Name = "Águas de Lindóia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4711,
					Name = "Águas de Santa Bárbara",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4712,
					Name = "Águas de São Pedro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4713,
					Name = "Agudos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4714,
					Name = "Alambari",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4715,
					Name = "Alfredo Marcondes",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4716,
					Name = "Altair",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4717,
					Name = "Altinópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4718,
					Name = "Alto Alegre",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4719,
					Name = "Alumínio",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4720,
					Name = "Álvares Florence",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4721,
					Name = "Álvares Machado",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4722,
					Name = "Álvaro de Carvalho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4723,
					Name = "Alvinlândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4724,
					Name = "Americana",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4725,
					Name = "Américo Brasiliense",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4726,
					Name = "Américo de Campos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4727,
					Name = "Amparo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4728,
					Name = "Analândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4729,
					Name = "Andradina",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4730,
					Name = "Angatuba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4731,
					Name = "Anhembi",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4732,
					Name = "Anhumas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4733,
					Name = "Aparecida",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4734,
					Name = "Aparecida d`Oeste",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4735,
					Name = "Apiaí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4736,
					Name = "Araçariguama",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4737,
					Name = "Araçatuba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4738,
					Name = "Araçoiaba da Serra",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4739,
					Name = "Aramina",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4740,
					Name = "Arandu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4741,
					Name = "Arapeí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4742,
					Name = "Araraquara",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4743,
					Name = "Araras",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4744,
					Name = "Arco-Íris",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4745,
					Name = "Arealva",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4746,
					Name = "Areias",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4747,
					Name = "Areiópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4748,
					Name = "Ariranha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4749,
					Name = "Artur Nogueira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4750,
					Name = "Arujá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4751,
					Name = "Aspásia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4752,
					Name = "Assis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4753,
					Name = "Atibaia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4754,
					Name = "Auriflama",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4755,
					Name = "Avaí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4756,
					Name = "Avanhandava",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4757,
					Name = "Avaré",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4758,
					Name = "Bady Bassitt",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4759,
					Name = "Balbinos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4760,
					Name = "Bálsamo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4761,
					Name = "Bananal",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4762,
					Name = "Barão de Antonina",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4763,
					Name = "Barbosa",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4764,
					Name = "Bariri",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4765,
					Name = "Barra Bonita",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4766,
					Name = "Barra do Chapéu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4767,
					Name = "Barra do Turvo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4768,
					Name = "Barretos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4769,
					Name = "Barrinha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4770,
					Name = "Barueri",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4771,
					Name = "Bastos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4772,
					Name = "Batatais",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4773,
					Name = "Bauru",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4774,
					Name = "Bebedouro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4775,
					Name = "Bento de Abreu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4776,
					Name = "Bernardino de Campos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4777,
					Name = "Bertioga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4778,
					Name = "Bilac",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4779,
					Name = "Birigui",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4780,
					Name = "Biritiba-Mirim",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4781,
					Name = "Boa Esperança do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4782,
					Name = "Bocaina",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4783,
					Name = "Bofete",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4784,
					Name = "Boituva",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4785,
					Name = "Bom Jesus dos Perdões",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4786,
					Name = "Bom Sucesso de Itararé",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4787,
					Name = "Borá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4788,
					Name = "Boracéia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4789,
					Name = "Borborema",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4790,
					Name = "Borebi",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4791,
					Name = "Botucatu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4792,
					Name = "Bragança Paulista",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4793,
					Name = "Braúna",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4794,
					Name = "Brejo Alegre",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4795,
					Name = "Brodowski",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4796,
					Name = "Brotas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4797,
					Name = "Buri",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4798,
					Name = "Buritama",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4799,
					Name = "Buritizal",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4800,
					Name = "Cabrália Paulista",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4801,
					Name = "Cabreúva",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4802,
					Name = "Caçapava",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4803,
					Name = "Cachoeira Paulista",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4804,
					Name = "Caconde",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4805,
					Name = "Cafelândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4806,
					Name = "Caiabu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4807,
					Name = "Caieiras",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4808,
					Name = "Caiuá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4809,
					Name = "Cajamar",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4810,
					Name = "Cajati",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4811,
					Name = "Cajobi",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4812,
					Name = "Cajuru",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4813,
					Name = "Campina do Monte Alegre",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4814,
					Name = "Campinas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4815,
					Name = "Campo Limpo Paulista",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4816,
					Name = "Campos do Jordão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4817,
					Name = "Campos Novos Paulista",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4818,
					Name = "Cananéia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4819,
					Name = "Canas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4820,
					Name = "Cândido Mota",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4821,
					Name = "Cândido Rodrigues",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4822,
					Name = "Canitar",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4823,
					Name = "Capão Bonito",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4824,
					Name = "Capela do Alto",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4825,
					Name = "Capivari",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4826,
					Name = "Caraguatatuba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4827,
					Name = "Carapicuíba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4828,
					Name = "Cardoso",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4829,
					Name = "Casa Branca",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4830,
					Name = "Cássia dos Coqueiros",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4831,
					Name = "Castilho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4832,
					Name = "Catanduva",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4833,
					Name = "Catiguá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4834,
					Name = "Cedral",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4835,
					Name = "Cerqueira César",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4836,
					Name = "Cerquilho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4837,
					Name = "Cesário Lange",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4838,
					Name = "Charqueada",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4839,
					Name = "Chavantes",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4840,
					Name = "Clementina",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4841,
					Name = "Colina",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4842,
					Name = "Colômbia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4843,
					Name = "Conchal",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4844,
					Name = "Conchas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4845,
					Name = "Cordeirópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4846,
					Name = "Coroados",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4847,
					Name = "Coronel Macedo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4848,
					Name = "Corumbataí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4849,
					Name = "Cosmópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4850,
					Name = "Cosmorama",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4851,
					Name = "Cotia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4852,
					Name = "Cravinhos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4853,
					Name = "Cristais Paulista",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4854,
					Name = "Cruzália",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4855,
					Name = "Cruzeiro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4856,
					Name = "Cubatão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4857,
					Name = "Cunha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4858,
					Name = "Descalvado",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4859,
					Name = "Diadema",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4860,
					Name = "Dirce Reis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4861,
					Name = "Divinolândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4862,
					Name = "Dobrada",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4863,
					Name = "Dois Córregos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4864,
					Name = "Dolcinópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4865,
					Name = "Dourado",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4866,
					Name = "Dracena",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4867,
					Name = "Duartina",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4868,
					Name = "Dumont",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4869,
					Name = "Echaporã",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4870,
					Name = "Eldorado",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4871,
					Name = "Elias Fausto",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4872,
					Name = "Elisiário",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4873,
					Name = "Embaúba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4874,
					Name = "Embu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4875,
					Name = "Embu-Guaçu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4876,
					Name = "Emilianópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4877,
					Name = "Engenheiro Coelho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4878,
					Name = "Espírito Santo do Pinhal",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4879,
					Name = "Espírito Santo do Turvo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4880,
					Name = "Estiva Gerbi",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4881,
					Name = "Estrela d`Oeste",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4882,
					Name = "Estrela do Norte",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4883,
					Name = "Euclides da Cunha Paulista",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4884,
					Name = "Fartura",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4885,
					Name = "Fernando Prestes",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4886,
					Name = "Fernandópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4887,
					Name = "Fernão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4888,
					Name = "Ferraz de Vasconcelos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4889,
					Name = "Flora Rica",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4890,
					Name = "Floreal",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4891,
					Name = "Flórida Paulista",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4892,
					Name = "Florínia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4893,
					Name = "Franca",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4894,
					Name = "Francisco Morato",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4895,
					Name = "Franco da Rocha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4896,
					Name = "Gabriel Monteiro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4897,
					Name = "Gália",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4898,
					Name = "Garça",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4899,
					Name = "Gastão Vidigal",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4900,
					Name = "Gavião Peixoto",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4901,
					Name = "General Salgado",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4902,
					Name = "Getulina",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4903,
					Name = "Glicério",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4904,
					Name = "Guaiçara",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4905,
					Name = "Guaimbê",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4906,
					Name = "Guaíra",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4907,
					Name = "Guapiaçu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4908,
					Name = "Guapiara",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4909,
					Name = "Guará",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4910,
					Name = "Guaraçaí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4911,
					Name = "Guaraci",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4912,
					Name = "Guarani d`Oeste",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4913,
					Name = "Guarantã",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4914,
					Name = "Guararapes",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4915,
					Name = "Guararema",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4916,
					Name = "Guaratinguetá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4917,
					Name = "Guareí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4918,
					Name = "Guariba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4919,
					Name = "Guarujá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4920,
					Name = "Guarulhos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4921,
					Name = "Guatapará",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4922,
					Name = "Guzolândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4923,
					Name = "Herculândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4924,
					Name = "Holambra",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4925,
					Name = "Hortolândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4926,
					Name = "Iacanga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4927,
					Name = "Iacri",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4928,
					Name = "Iaras",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4929,
					Name = "Ibaté",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4930,
					Name = "Ibirá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4931,
					Name = "Ibirarema",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4932,
					Name = "Ibitinga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4933,
					Name = "Ibiúna",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4934,
					Name = "Icém",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4935,
					Name = "Iepê",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4936,
					Name = "Igaraçu do Tietê",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4937,
					Name = "Igarapava",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4938,
					Name = "Igaratá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4939,
					Name = "Iguape",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4940,
					Name = "Ilha Comprida",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4941,
					Name = "Ilha Solteira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4942,
					Name = "Ilhabela",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4943,
					Name = "Indaiatuba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4944,
					Name = "Indiana",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4945,
					Name = "Indiaporã",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4946,
					Name = "Inúbia Paulista",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4947,
					Name = "Ipaussu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4948,
					Name = "Iperó",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4949,
					Name = "Ipeúna",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4950,
					Name = "Ipiguá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4951,
					Name = "Iporanga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4952,
					Name = "Ipuã",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4953,
					Name = "Iracemápolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4954,
					Name = "Irapuã",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4955,
					Name = "Irapuru",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4956,
					Name = "Itaberá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4957,
					Name = "Itaí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4958,
					Name = "Itajobi",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4959,
					Name = "Itaju",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4960,
					Name = "Itanhaém",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4961,
					Name = "Itaóca",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4962,
					Name = "Itapecerica da Serra",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4963,
					Name = "Itapetininga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4964,
					Name = "Itapeva",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4965,
					Name = "Itapevi",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4966,
					Name = "Itapira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4967,
					Name = "Itapirapuã Paulista",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4968,
					Name = "Itápolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4969,
					Name = "Itaporanga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4970,
					Name = "Itapuí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4971,
					Name = "Itapura",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4972,
					Name = "Itaquaquecetuba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4973,
					Name = "Itararé",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4974,
					Name = "Itariri",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4975,
					Name = "Itatiba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4976,
					Name = "Itatinga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4977,
					Name = "Itirapina",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4978,
					Name = "Itirapuã",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4979,
					Name = "Itobi",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4980,
					Name = "Itu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4981,
					Name = "Itupeva",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4982,
					Name = "Ituverava",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4983,
					Name = "Jaborandi",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4984,
					Name = "Jaboticabal",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4985,
					Name = "Jacareí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4986,
					Name = "Jaci",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4987,
					Name = "Jacupiranga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4988,
					Name = "Jaguariúna",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4989,
					Name = "Jales",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4990,
					Name = "Jambeiro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4991,
					Name = "Jandira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4992,
					Name = "Jardinópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4993,
					Name = "Jarinu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4994,
					Name = "Jaú",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4995,
					Name = "Jeriquara",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4996,
					Name = "Joanópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4997,
					Name = "João Ramalho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4998,
					Name = "José Bonifácio",
					Active = false,
				},
				new CityEntity()
		{
			Id = 4999,
					Name = "Júlio Mesquita",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5000,
					Name = "Jumirim",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5001,
					Name = "Jundiaí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5002,
					Name = "Junqueirópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5003,
					Name = "Juquiá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5004,
					Name = "Juquitiba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5005,
					Name = "Lagoinha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5006,
					Name = "Laranjal Paulista",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5007,
					Name = "Lavínia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5008,
					Name = "Lavrinhas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5009,
					Name = "Leme",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5010,
					Name = "Lençóis Paulista",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5011,
					Name = "Limeira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5012,
					Name = "Lindóia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5013,
					Name = "Lins",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5014,
					Name = "Lorena",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5015,
					Name = "Lourdes",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5016,
					Name = "Louveira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5017,
					Name = "Lucélia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5018,
					Name = "Lucianópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5019,
					Name = "Luís Antônio",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5020,
					Name = "Luiziânia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5021,
					Name = "Lupércio",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5022,
					Name = "Lutécia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5023,
					Name = "Macatuba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5024,
					Name = "Macaubal",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5025,
					Name = "Macedônia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5026,
					Name = "Magda",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5027,
					Name = "Mairinque",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5028,
					Name = "Mairiporã",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5029,
					Name = "Manduri",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5030,
					Name = "Marabá Paulista",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5031,
					Name = "Maracaí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5032,
					Name = "Marapoama",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5033,
					Name = "Mariápolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5034,
					Name = "Marília",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5035,
					Name = "Marinópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5036,
					Name = "Martinópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5037,
					Name = "Matão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5038,
					Name = "Mauá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5039,
					Name = "Mendonça",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5040,
					Name = "Meridiano",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5041,
					Name = "Mesópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5042,
					Name = "Miguelópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5043,
					Name = "Mineiros do Tietê",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5044,
					Name = "Mira Estrela",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5045,
					Name = "Miracatu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5046,
					Name = "Mirandópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5047,
					Name = "Mirante do Paranapanema",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5048,
					Name = "Mirassol",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5049,
					Name = "Mirassolândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5050,
					Name = "Mococa",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5051,
					Name = "Mogi das Cruzes",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5052,
					Name = "Mogi Guaçu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5053,
					Name = "Moji Mirim",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5054,
					Name = "Mombuca",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5055,
					Name = "Monções",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5056,
					Name = "Mongaguá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5057,
					Name = "Monte Alegre do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5058,
					Name = "Monte Alto",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5059,
					Name = "Monte Aprazível",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5060,
					Name = "Monte Azul Paulista",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5061,
					Name = "Monte Castelo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5062,
					Name = "Monte Mor",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5063,
					Name = "Monteiro Lobato",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5064,
					Name = "Morro Agudo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5065,
					Name = "Morungaba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5066,
					Name = "Motuca",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5067,
					Name = "Murutinga do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5068,
					Name = "Nantes",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5069,
					Name = "Narandiba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5070,
					Name = "Natividade da Serra",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5071,
					Name = "Nazaré Paulista",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5072,
					Name = "Neves Paulista",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5073,
					Name = "Nhandeara",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5074,
					Name = "Nipoã",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5075,
					Name = "Nova Aliança",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5076,
					Name = "Nova Campina",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5077,
					Name = "Nova Canaã Paulista",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5078,
					Name = "Nova Castilho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5079,
					Name = "Nova Europa",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5080,
					Name = "Nova Granada",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5081,
					Name = "Nova Guataporanga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5082,
					Name = "Nova Independência",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5083,
					Name = "Nova Luzitânia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5084,
					Name = "Nova Odessa",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5085,
					Name = "Novais",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5086,
					Name = "Novo Horizonte",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5087,
					Name = "Nuporanga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5088,
					Name = "Ocauçu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5089,
					Name = "Óleo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5090,
					Name = "Olímpia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5091,
					Name = "Onda Verde",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5092,
					Name = "Oriente",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5093,
					Name = "Orindiúva",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5094,
					Name = "Orlândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5095,
					Name = "Osasco",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5096,
					Name = "Oscar Bressane",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5097,
					Name = "Osvaldo Cruz",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5098,
					Name = "Ourinhos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5099,
					Name = "Ouro Verde",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5100,
					Name = "Ouroeste",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5101,
					Name = "Pacaembu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5102,
					Name = "Palestina",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5103,
					Name = "Palmares Paulista",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5104,
					Name = "Palmeira d`Oeste",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5105,
					Name = "Palmital",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5106,
					Name = "Panorama",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5107,
					Name = "Paraguaçu Paulista",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5108,
					Name = "Paraibuna",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5109,
					Name = "Paraíso",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5110,
					Name = "Paranapanema",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5111,
					Name = "Paranapuã",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5112,
					Name = "Parapuã",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5113,
					Name = "Pardinho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5114,
					Name = "Pariquera-Açu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5115,
					Name = "Parisi",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5116,
					Name = "Patrocínio Paulista",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5117,
					Name = "Paulicéia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5118,
					Name = "Paulínia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5119,
					Name = "Paulistânia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5120,
					Name = "Paulo de Faria",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5121,
					Name = "Pederneiras",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5122,
					Name = "Pedra Bela",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5123,
					Name = "Pedranópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5124,
					Name = "Pedregulho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5125,
					Name = "Pedreira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5126,
					Name = "Pedrinhas Paulista",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5127,
					Name = "Pedro de Toledo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5128,
					Name = "Penápolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5129,
					Name = "Pereira Barreto",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5130,
					Name = "Pereiras",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5131,
					Name = "Peruíbe",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5132,
					Name = "Piacatu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5133,
					Name = "Piedade",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5134,
					Name = "Pilar do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5135,
					Name = "Pindamonhangaba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5136,
					Name = "Pindorama",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5137,
					Name = "Pinhalzinho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5138,
					Name = "Piquerobi",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5139,
					Name = "Piquete",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5140,
					Name = "Piracaia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5141,
					Name = "Piracicaba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5142,
					Name = "Piraju",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5143,
					Name = "Pirajuí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5144,
					Name = "Pirangi",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5145,
					Name = "Pirapora do Bom Jesus",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5146,
					Name = "Pirapozinho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5147,
					Name = "Pirassununga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5148,
					Name = "Piratininga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5149,
					Name = "Pitangueiras",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5150,
					Name = "Planalto",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5151,
					Name = "Platina",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5152,
					Name = "Poá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5153,
					Name = "Poloni",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5154,
					Name = "Pompéia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5155,
					Name = "Pongaí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5156,
					Name = "Pontal",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5157,
					Name = "Pontalinda",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5158,
					Name = "Pontes Gestal",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5159,
					Name = "Populina",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5160,
					Name = "Porangaba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5161,
					Name = "Porto Feliz",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5162,
					Name = "Porto Ferreira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5163,
					Name = "Potim",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5164,
					Name = "Potirendaba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5165,
					Name = "Pracinha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5166,
					Name = "Pradópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5167,
					Name = "Praia Grande",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5168,
					Name = "Pratânia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5169,
					Name = "Presidente Alves",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5170,
					Name = "Presidente Bernardes",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5171,
					Name = "Presidente Epitácio",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5172,
					Name = "Presidente Prudente",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5173,
					Name = "Presidente Venceslau",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5174,
					Name = "Promissão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5175,
					Name = "Quadra",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5176,
					Name = "Quatá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5177,
					Name = "Queiroz",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5178,
					Name = "Queluz",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5179,
					Name = "Quintana",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5180,
					Name = "Rafard",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5181,
					Name = "Rancharia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5182,
					Name = "Redenção da Serra",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5183,
					Name = "Regente Feijó",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5184,
					Name = "Reginópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5185,
					Name = "Registro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5186,
					Name = "Restinga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5187,
					Name = "Ribeira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5188,
					Name = "Ribeirão Bonito",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5189,
					Name = "Ribeirão Branco",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5190,
					Name = "Ribeirão Corrente",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5191,
					Name = "Ribeirão do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5192,
					Name = "Ribeirão dos Índios",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5193,
					Name = "Ribeirão Grande",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5194,
					Name = "Ribeirão Pires",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5195,
					Name = "Ribeirão Preto",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5196,
					Name = "Rifaina",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5197,
					Name = "Rincão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5198,
					Name = "Rinópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5199,
					Name = "Rio Claro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5200,
					Name = "Rio das Pedras",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5201,
					Name = "Rio Grande da Serra",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5202,
					Name = "Riolândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5203,
					Name = "Riversul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5204,
					Name = "Rosana",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5205,
					Name = "Roseira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5206,
					Name = "Rubiácea",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5207,
					Name = "Rubinéia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5208,
					Name = "Sabino",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5209,
					Name = "Sagres",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5210,
					Name = "Sales",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5211,
					Name = "Sales Oliveira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5212,
					Name = "Salesópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5213,
					Name = "Salmourão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5214,
					Name = "Saltinho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5215,
					Name = "Salto",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5216,
					Name = "Salto de Pirapora",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5217,
					Name = "Salto Grande",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5218,
					Name = "Sandovalina",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5219,
					Name = "Santa Adélia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5220,
					Name = "Santa Albertina",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5221,
					Name = "Santa Bárbara d`Oeste",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5222,
					Name = "Santa Branca",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5223,
					Name = "Santa Clara d`Oeste",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5224,
					Name = "Santa Cruz da Conceição",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5225,
					Name = "Santa Cruz da Esperança",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5226,
					Name = "Santa Cruz das Palmeiras",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5227,
					Name = "Santa Cruz do Rio Pardo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5228,
					Name = "Santa Ernestina",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5229,
					Name = "Santa Fé do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5230,
					Name = "Santa Gertrudes",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5231,
					Name = "Santa Isabel",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5232,
					Name = "Santa Lúcia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5233,
					Name = "Santa Maria da Serra",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5234,
					Name = "Santa Mercedes",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5235,
					Name = "Santa Rita d`Oeste",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5236,
					Name = "Santa Rita do Passa Quatro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5237,
					Name = "Santa Rosa de Viterbo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5238,
					Name = "Santa Salete",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5239,
					Name = "Santana da Ponte Pensa",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5240,
					Name = "Santana de Parnaíba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5241,
					Name = "Santo Anastácio",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5242,
					Name = "Santo André",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5243,
					Name = "Santo Antônio da Alegria",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5244,
					Name = "Santo Antônio de Posse",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5245,
					Name = "Santo Antônio do Aracanguá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5246,
					Name = "Santo Antônio do Jardim",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5247,
					Name = "Santo Antônio do Pinhal",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5248,
					Name = "Santo Expedito",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5249,
					Name = "Santópolis do Aguapeí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5250,
					Name = "Santos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5251,
					Name = "São Bento do Sapucaí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5252,
					Name = "São Bernardo do Campo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5253,
					Name = "São Caetano do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5254,
					Name = "São Carlos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5255,
					Name = "São Francisco",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5256,
					Name = "São João da Boa Vista",
					Active = true,
				},
				new CityEntity()
		{
			Id = 5257,
					Name = "São João das Duas Pontes",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5258,
					Name = "São João de Iracema",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5259,
					Name = "São João do Pau d`Alho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5260,
					Name = "São Joaquim da Barra",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5261,
					Name = "São José da Bela Vista",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5262,
					Name = "São José do Barreiro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5263,
					Name = "São José do Rio Pardo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5264,
					Name = "São José do Rio Preto",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5265,
					Name = "São José dos Campos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5266,
					Name = "São Lourenço da Serra",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5267,
					Name = "São Luís do Paraitinga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5268,
					Name = "São Manuel",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5269,
					Name = "São Miguel Arcanjo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5270,
					Name = "São Paulo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5271,
					Name = "São Pedro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5272,
					Name = "São Pedro do Turvo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5273,
					Name = "São Roque",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5274,
					Name = "São Sebastião",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5275,
					Name = "São Sebastião da Grama",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5276,
					Name = "São Simão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5277,
					Name = "São Vicente",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5278,
					Name = "Sarapuí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5279,
					Name = "Sarutaiá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5280,
					Name = "Sebastianópolis do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5281,
					Name = "Serra Azul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5282,
					Name = "Serra Negra",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5283,
					Name = "Serrana",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5284,
					Name = "Sertãozinho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5285,
					Name = "Sete Barras",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5286,
					Name = "Severínia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5287,
					Name = "Silveiras",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5288,
					Name = "Socorro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5289,
					Name = "Sorocaba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5290,
					Name = "Sud Mennucci",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5291,
					Name = "Sumaré",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5292,
					Name = "Suzanápolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5293,
					Name = "Suzano",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5294,
					Name = "Tabapuã",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5295,
					Name = "Tabatinga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5296,
					Name = "Taboão da Serra",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5297,
					Name = "Taciba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5298,
					Name = "Taguaí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5299,
					Name = "Taiaçu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5300,
					Name = "Taiúva",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5301,
					Name = "Tambaú",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5302,
					Name = "Tanabi",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5303,
					Name = "Tapiraí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5304,
					Name = "Tapiratiba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5305,
					Name = "Taquaral",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5306,
					Name = "Taquaritinga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5307,
					Name = "Taquarituba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5308,
					Name = "Taquarivaí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5309,
					Name = "Tarabai",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5310,
					Name = "Tarumã",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5311,
					Name = "Tatuí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5312,
					Name = "Taubaté",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5313,
					Name = "Tejupá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5314,
					Name = "Teodoro Sampaio",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5315,
					Name = "Terra Roxa",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5316,
					Name = "Tietê",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5317,
					Name = "Timburi",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5318,
					Name = "Torre de Pedra",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5319,
					Name = "Torrinha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5320,
					Name = "Trabiju",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5321,
					Name = "Tremembé",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5322,
					Name = "Três Fronteiras",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5323,
					Name = "Tuiuti",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5324,
					Name = "Tupã",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5325,
					Name = "Tupi Paulista",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5326,
					Name = "Turiúba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5327,
					Name = "Turmalina",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5328,
					Name = "Ubarana",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5329,
					Name = "Ubatuba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5330,
					Name = "Ubirajara",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5331,
					Name = "Uchoa",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5332,
					Name = "União Paulista",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5333,
					Name = "Urânia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5334,
					Name = "Uru",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5335,
					Name = "Urupês",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5336,
					Name = "Valentim Gentil",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5337,
					Name = "Valinhos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5338,
					Name = "Valparaíso",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5339,
					Name = "Vargem",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5340,
					Name = "Vargem Grande do Sul",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5341,
					Name = "Vargem Grande Paulista",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5342,
					Name = "Várzea Paulista",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5343,
					Name = "Vera Cruz",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5344,
					Name = "Vinhedo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5345,
					Name = "Viradouro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5346,
					Name = "Vista Alegre do Alto",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5347,
					Name = "Vitória Brasil",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5348,
					Name = "Votorantim",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5349,
					Name = "Votuporanga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5350,
					Name = "Zacarias",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5351,
					Name = "Amparo de São Francisco",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5352,
					Name = "Aquidabã",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5353,
					Name = "Aracaju",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5354,
					Name = "Arauá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5355,
					Name = "Areia Branca",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5356,
					Name = "Barra dos Coqueiros",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5357,
					Name = "Boquim",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5358,
					Name = "Brejo Grande",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5359,
					Name = "Campo do Brito",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5360,
					Name = "Canhoba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5361,
					Name = "Canindé de São Francisco",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5362,
					Name = "Capela",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5363,
					Name = "Carira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5364,
					Name = "Carmópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5365,
					Name = "Cedro de São João",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5366,
					Name = "Cristinápolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5367,
					Name = "Cumbe",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5368,
					Name = "Divina Pastora",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5369,
					Name = "Estância",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5370,
					Name = "Feira Nova",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5371,
					Name = "Frei Paulo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5372,
					Name = "Gararu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5373,
					Name = "General Maynard",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5374,
					Name = "Gracho Cardoso",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5375,
					Name = "Ilha das Flores",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5376,
					Name = "Indiaroba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5377,
					Name = "Itabaiana",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5378,
					Name = "Itabaianinha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5379,
					Name = "Itabi",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5380,
					Name = "Itaporanga d`Ajuda",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5381,
					Name = "Japaratuba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5382,
					Name = "Japoatã",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5383,
					Name = "Lagarto",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5384,
					Name = "Laranjeiras",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5385,
					Name = "Macambira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5386,
					Name = "Malhada dos Bois",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5387,
					Name = "Malhador",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5388,
					Name = "Maruim",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5389,
					Name = "Moita Bonita",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5390,
					Name = "Monte Alegre de Sergipe",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5391,
					Name = "Muribeca",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5392,
					Name = "Neópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5393,
					Name = "Nossa Senhora Aparecida",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5394,
					Name = "Nossa Senhora da Glória",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5395,
					Name = "Nossa Senhora das Dores",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5396,
					Name = "Nossa Senhora de Lourdes",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5397,
					Name = "Nossa Senhora do Socorro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5398,
					Name = "Pacatuba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5399,
					Name = "Pedra Mole",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5400,
					Name = "Pedrinhas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5401,
					Name = "Pinhão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5402,
					Name = "Pirambu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5403,
					Name = "Poço Redondo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5404,
					Name = "Poço Verde",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5405,
					Name = "Porto da Folha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5406,
					Name = "Propriá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5407,
					Name = "Riachão do Dantas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5408,
					Name = "Riachuelo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5409,
					Name = "Ribeirópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5410,
					Name = "Rosário do Catete",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5411,
					Name = "Salgado",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5412,
					Name = "Santa Luzia do Itanhy",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5413,
					Name = "Santa Rosa de Lima",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5414,
					Name = "Santana do São Francisco",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5415,
					Name = "Santo Amaro das Brotas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5416,
					Name = "São Cristóvão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5417,
					Name = "São Domingos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5418,
					Name = "São Francisco",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5419,
					Name = "São Miguel do Aleixo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5420,
					Name = "Simão Dias",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5421,
					Name = "Siriri",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5422,
					Name = "Telha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5423,
					Name = "Tobias Barreto",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5424,
					Name = "Tomar do Geru",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5425,
					Name = "Umbaúba",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5426,
					Name = "Abreulândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5427,
					Name = "Aguiarnópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5428,
					Name = "Aliança do Tocantins",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5429,
					Name = "Almas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5430,
					Name = "Alvorada",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5431,
					Name = "Ananás",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5432,
					Name = "Angico",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5433,
					Name = "Aparecida do Rio Negro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5434,
					Name = "Aragominas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5435,
					Name = "Araguacema",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5436,
					Name = "Araguaçu",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5437,
					Name = "Araguaína",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5438,
					Name = "Araguanã",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5439,
					Name = "Araguatins",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5440,
					Name = "Arapoema",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5441,
					Name = "Arraias",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5442,
					Name = "Augustinópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5443,
					Name = "Aurora do Tocantins",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5444,
					Name = "Axixá do Tocantins",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5445,
					Name = "Babaçulândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5446,
					Name = "Bandeirantes do Tocantins",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5447,
					Name = "Barra do Ouro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5448,
					Name = "Barrolândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5449,
					Name = "Bernardo Sayão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5450,
					Name = "Bom Jesus do Tocantins",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5451,
					Name = "Brasilândia do Tocantins",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5452,
					Name = "Brejinho de Nazaré",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5453,
					Name = "Buriti do Tocantins",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5454,
					Name = "Cachoeirinha",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5455,
					Name = "Campos Lindos",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5456,
					Name = "Cariri do Tocantins",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5457,
					Name = "Carmolândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5458,
					Name = "Carrasco Bonito",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5459,
					Name = "Caseara",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5460,
					Name = "Centenário",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5461,
					Name = "Chapada da Natividade",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5462,
					Name = "Chapada de Areia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5463,
					Name = "Colinas do Tocantins",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5464,
					Name = "Colméia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5465,
					Name = "Combinado",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5466,
					Name = "Conceição do Tocantins",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5467,
					Name = "Couto de Magalhães",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5468,
					Name = "Cristalândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5469,
					Name = "Crixás do Tocantins",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5470,
					Name = "Darcinópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5471,
					Name = "Dianópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5472,
					Name = "Divinópolis do Tocantins",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5473,
					Name = "Dois Irmãos do Tocantins",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5474,
					Name = "Dueré",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5475,
					Name = "Esperantina",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5476,
					Name = "Fátima",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5477,
					Name = "Figueirópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5478,
					Name = "Filadélfia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5479,
					Name = "Formoso do Araguaia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5480,
					Name = "Fortaleza do Tabocão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5481,
					Name = "Goianorte",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5482,
					Name = "Goiatins",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5483,
					Name = "Guaraí",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5484,
					Name = "Gurupi",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5485,
					Name = "Ipueiras",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5486,
					Name = "Itacajá",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5487,
					Name = "Itaguatins",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5488,
					Name = "Itapiratins",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5489,
					Name = "Itaporã do Tocantins",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5490,
					Name = "Jaú do Tocantins",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5491,
					Name = "Juarina",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5492,
					Name = "Lagoa da Confusão",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5493,
					Name = "Lagoa do Tocantins",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5494,
					Name = "Lajeado",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5495,
					Name = "Lavandeira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5496,
					Name = "Lizarda",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5497,
					Name = "Luzinópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5498,
					Name = "Marianópolis do Tocantins",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5499,
					Name = "Mateiros",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5500,
					Name = "Maurilândia do Tocantins",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5501,
					Name = "Miracema do Tocantins",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5502,
					Name = "Miranorte",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5503,
					Name = "Monte do Carmo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5504,
					Name = "Monte Santo do Tocantins",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5505,
					Name = "Muricilândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5506,
					Name = "Natividade",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5507,
					Name = "Nazaré",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5508,
					Name = "Nova Olinda",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5509,
					Name = "Nova Rosalândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5510,
					Name = "Novo Acordo",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5511,
					Name = "Novo Alegre",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5512,
					Name = "Novo Jardim",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5513,
					Name = "Oliveira de Fátima",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5514,
					Name = "Palmas",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5515,
					Name = "Palmeirante",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5516,
					Name = "Palmeiras do Tocantins",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5517,
					Name = "Palmeirópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5518,
					Name = "Paraíso do Tocantins",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5519,
					Name = "Paranã",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5520,
					Name = "Pau d`Arco",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5521,
					Name = "Pedro Afonso",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5522,
					Name = "Peixe",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5523,
					Name = "Pequizeiro",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5524,
					Name = "Pindorama do Tocantins",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5525,
					Name = "Piraquê",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5526,
					Name = "Pium",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5527,
					Name = "Ponte Alta do Bom Jesus",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5528,
					Name = "Ponte Alta do Tocantins",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5529,
					Name = "Porto Alegre do Tocantins",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5530,
					Name = "Porto Nacional",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5531,
					Name = "Praia Norte",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5532,
					Name = "Presidente Kennedy",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5533,
					Name = "Pugmil",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5534,
					Name = "Recursolândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5535,
					Name = "Riachinho",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5536,
					Name = "Rio da Conceição",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5537,
					Name = "Rio dos Bois",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5538,
					Name = "Rio Sono",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5539,
					Name = "Sampaio",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5540,
					Name = "Sandolândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5541,
					Name = "Santa Fé do Araguaia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5542,
					Name = "Santa Maria do Tocantins",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5543,
					Name = "Santa Rita do Tocantins",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5544,
					Name = "Santa Rosa do Tocantins",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5545,
					Name = "Santa Tereza do Tocantins",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5546,
					Name = "Santa Terezinha do Tocantins",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5547,
					Name = "São Bento do Tocantins",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5548,
					Name = "São Félix do Tocantins",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5549,
					Name = "São Miguel do Tocantins",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5550,
					Name = "São Salvador do Tocantins",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5551,
					Name = "São Sebastião do Tocantins",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5552,
					Name = "São Valério da Natividade",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5553,
					Name = "Silvanópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5554,
					Name = "Sítio Novo do Tocantins",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5555,
					Name = "Sucupira",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5556,
					Name = "Taguatinga",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5557,
					Name = "Taipas do Tocantins",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5558,
					Name = "Talismã",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5559,
					Name = "Tocantínia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5560,
					Name = "Tocantinópolis",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5561,
					Name = "Tupirama",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5562,
					Name = "Tupiratins",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5563,
					Name = "Wanderlândia",
					Active = false,
				},
				new CityEntity()
		{
			Id = 5564,
					Name = "Xambioá",
					Active = false,
				}
	};

	}
}
