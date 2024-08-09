import Products from "./components/Products";
import Users from "./components/Users";

export default function Home() {
  return (
    <main className="h-screen flex items-center justify-center w-full gap-10">
      <Users />
      <Products />
    </main>
  );
}
