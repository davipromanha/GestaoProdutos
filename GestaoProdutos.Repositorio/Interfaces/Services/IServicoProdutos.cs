﻿using GestaoProdutos.Dominio.Entity;
using System;
using System.Threading.Tasks;

namespace GestaoProdutos.Dominio.Repositorio.Interfaces.Services
{
    public interface IServicoProdutos : IServicoComum<Produtos>
    {
        Task<Produtos> Post(Produtos entidade);

        Task<Produtos> Put(Produtos entidade);

        Task<Produtos> Put(int id);

        bool ValidaDataFabricacao(DateTime data_fabricacao, DateTime data_validade);
    }
}