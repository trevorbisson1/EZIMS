import { useGetItemsQuery } from "../src/Redux/ApiSlice/ApiSlice"
function App() {
    const { data: data } = useGetItemsQuery(1);
    return (
        <div>
        <h3>Hello!</h3>
            {data && <div> <h1> Here: { data}</h1></div> }
        </div>
  )
}

export default App
