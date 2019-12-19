import React, {Component} from 'react';
import 'bootstrap/dist/css/bootstrap.min.css';
import './App.css';
import Form from './FormAddPlayer.js';
import Players from './Player.js';
import Nav from 'react-bootstrap/Nav';
import Navbar from 'react-bootstrap/Navbar';
import EditPlayer from './EditFormPlayer.js';
import {
  BrowserRouter as Router,
          Switch,
          Route,
          Link,
          useParams,
          Redirect
          } from "react-router-dom";

function App (){
  return (
    <Router>
        <div>
          <Navbar bg="light" variant="light">
            <Navbar.Brand href="/">Home</Navbar.Brand>
            <Nav className="mr-auto">
                      {/* <li>
                          <Link to="/matches">Matches</Link>
                      </li> */}
              <Nav.Link href="/addPlayer">AddPlayer</Nav.Link>                    
            </Nav>
          </Navbar>     
     
            <Switch>
              <Route path="/edit/:id" component={Edit} />
              <Route exact path="/addPlayer" component={AddPlayer} />
              <Route exact path="/" component={Home} />
            </Switch>
        </div>
    </Router>
    );
}
function Home() {
  return <Players/>;
}

function Edit() {
  let {id} = useParams();
  return( <EditPlayer id={id}/> );
}
function AddPlayer(){
  return <Form/>
}
export default App;