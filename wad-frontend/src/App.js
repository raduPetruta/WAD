import Profile from "./pages/profile/profile";
import React from "react";
import Login from "./pages/login/login";
import { BrowserRouter as Router, Route, Switch } from "react-router-dom";

function App() {
  return (
    <Router>
      <Switch>
        <Route path="/login" component={Login}>
          <Login />
        </Route>
        <Route exact path="/" component={Profile}>
          <Profile />
        </Route>
      </Switch>
    </Router>
  );
}

export default App;
