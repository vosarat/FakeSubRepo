using System;
using System.Collections.Generic;
using System.Text;

using FakeMainRepo.Domain;

namespace FakeSubRepo.Domain
{
	class Process
	{
		public Worker worker;

		public Process(Worker worker)
		{
			this.worker = worker;
		}
	}
}
