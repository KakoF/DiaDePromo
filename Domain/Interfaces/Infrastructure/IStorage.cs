using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Infrastructure
{
	public interface IStorage
	{
		public void StoragePDFAsync(IFormFile file);
	}
}
