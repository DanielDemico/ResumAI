import { useState, useEffect } from 'react'
import PokemonCard from './components/PokemonCard'

function App() {
  const [data, setData] = useState([]);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState(null);

  useEffect(() => {
    const fetchData = async () => {
      try{
        const response = await fetch('https://pokeapi.co/api/v2/pokemon?limit=20')
        
        if (!response.ok) {
          throw new Error('Falha na conexão');
        }
        const result = await response.json();
        setData(result.results)
      } catch (err) {
        setError(err.message);
      } finally {
        setLoading(false);
      }
    }
    fetchData();
  }, []);

  if (loading) return <p> Carregando Dados... </p>
  if (error) return <p style={{color:'red'}}> Erro: {error}</p>

  return (
    <div>
      <h1> Pokemons Fodas </h1>
      <div style={{display: 'flex'}}>
        {data.map((pokemon) => (
          <PokemonCard
            key={pokemon.name}
            name={pokemon.name}
            url={pokemon.url}
          />
        ))}
      </div>
    </div>
  )
}

export default App
