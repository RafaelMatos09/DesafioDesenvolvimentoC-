import React, { useState, useEffect } from "react";
import axios from "axios";
import PokemonTable from "./components/PokemonTable";
import 'bootstrap/dist/css/bootstrap.min.css';

function App() {
  const [regions, setRegions] = useState([]);
  const [selectedRegion, setSelectedRegion] = useState("all");
  const [pokemonList, setPokemonList] = useState([]);

  useEffect(() => {
    axios.get("http://localhost:5145/api/Regiao/ListarRegioes").then((response) => {
      setRegions(response.data.dados);
    });
  }, []);

  useEffect(() => {
    const fetchPokemons = async () => {
      try {
        let response;
        if (selectedRegion === "all") {
          response = await axios.get("http://localhost:5145/api/Pokemon/ListarPokemons");
        } else {
          response = await axios.get(`http://localhost:5145/api/Pokemon/BuscarPokemonPorRegiao/${selectedRegion}`);
        }
        setPokemonList(response.data.dados);
      } catch (error) {
        console.error("Erro ao buscar Pokémon:", error);
      }
    };

    fetchPokemons();
  }, [selectedRegion]);

  return (
    <div className="container mt-5">
      <h1 className="text-center mb-4">Pokedex</h1>
      <div className="mb-3">
        <select
          className="form-select"
          onChange={(e) => setSelectedRegion(e.target.value)}
        >
          <option value="all">Todos</option>
          {regions.map((region) => (
            <option key={region.id} value={region.id}>
              {region.regiao}
            </option>
          ))}
        </select>
      </div>
      <PokemonTable pokemonList={pokemonList} />
    </div>
  );
}

export default App;
