﻿using GestaoProdutos.Dominio.Entity;
using System;
using System.Threading.Tasks;

namespace GestaoProdutos.Dominio.Repositorio.Interfaces
{
    public interface IRepositorioProdutos : IRepositorioComum<Produtos>
    {
        Task<Produtos> Inserir(Produtos entidade);

        Task<Produtos> Editar(Produtos entidade);

        Task<Produtos> RemoveProduto(int id);

        bool ValidaDataFabricacao(DateTime data_fabricacao, DateTime data_validade);
    }
}