﻿using SenaTur.Senai.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SenaTur.Senai.WebApi.Interfaces
{
    interface IPacotesRepository
    {
        IEnumerable<Pacotes> Listar(string Cidade);

        List<Pacotes> Listar();

        Pacotes BuscarPorId(int id);

        void Cadastrar(Pacotes novoPacote);

        Pacotes Atualizar(int id, Pacotes pacoteAtualizado);

        List<Pacotes> ListarValorDecrescente();

        List<Pacotes> ListarValorCrescente();

    }
}
