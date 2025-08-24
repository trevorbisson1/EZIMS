import { NavLink } from 'react-router';

function Landing() {
    return (
        <div className="Landing">
            <h1>Welcome to EZIMS</h1>
            <NavLink>Create an Account with us!</NavLink>
            <NavLink>Login</NavLink>
            <Navlink>See what EZIMS can do for your business</Navlink>
      </div>
  );
}

export default Landing;