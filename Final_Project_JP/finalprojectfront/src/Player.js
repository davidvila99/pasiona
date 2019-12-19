import React, { Component } from 'react';
import logo from './logo.svg';
import './App.css';
import EditPlayer from './EditFormPlayer.js';
import Table from 'react-bootstrap/Table';
import {
    BrowserRouter as Router,
    Switch,
    Route,
    Link,
    useParams,
    Redirect
} from "react-router-dom";

class Player extends Component {

    DelItem = () => {
        this.props.DelItem(this.props.id);
    }

    render() {
        return (
            <tr>
                <td>{this.props.id}</td>
                <td>{this.props.name}</td>
                <td>{this.props.mail}</td>
                <td>{this.props.username}</td>
                <td><Link to={"/edit/" + this.props.id}><button>Edit</button></Link>
                    <button onClick={this.DelItem}>Eliminar</button>
                    <button><Link to={"/edit/" + this.props.id}>Create Match</Link></button></td>
            </tr>
        );
    }
}

class Players extends Component {
    constructor(props) {
        super(props);
        this.state = {
            Players: []
        };
    }


    componentDidMount() {
        fetch("https://localhost:44375/api/Players")
            .then(response => response.json())
            .then(data => {
                this.setState({ Players: data })
                console.log(data)
            })
    }

    delete = (id) => {
        const params = {
            method: 'DELETE',
            headers: {
                "Content-type": "application/json; charset=UTF-8"
            }
        }
        fetch('https://localhost:44375/api/Players/' + id, params)
            .then(response =>
                this.componentDidMount())
            .catch(error => console.log(error));
    }

    render() {
        const filas = this.state.Players.map((fila) => {
            return (<Player key={fila.id} id={fila.id} name={fila.name} mail={fila.mail} username={fila.username} DelItem={this.delete} />)
        })
        return (
            <Table striped bordered hover>
                <thead>
                    <tr>
                        <th>Id</th>
                        <th>Name</th>
                        <th>Mail</th>
                        <th>Username</th>
                        <th>Options</th>
                    </tr>
                </thead>
                <tbody>
                    {filas}
                </tbody>
            </Table>
        )
    }
}
export default Players;