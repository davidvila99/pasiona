import React, {Component} from 'react';
import './App.css';

class Form extends Component {
    constructor(props) {
        super(props);
        this.state = {
            name: "",
            mail: "",
            username: ""
        };
    }

    cambio = (event) =>{
        const {name,value} = event.target;
        this.setState({
            [name]:value
        });
    }

    enviar = () => {
        let params = {
            method: 'POST',
            body: JSON.stringify(this.state),
            headers: {
                "Content-type": "application/json; charset=UTF-8"
            }
        };
        fetch('https://localhost:44375/api/Players', params)
            .then(response => response.json())
            .then(json => this.setState({
                name: "",
                mail: "",
                username: ""
            }))
    } 

    render() {
        return <div>
            <label>Name:</label>
            <input name="name" name={this.state.name} onChange={this.cambio}></input>
            <label>Mail:</label>
            <input name="mail" mail={this.state.mail} onChange={this.cambio}></input>
            <label>Username:</label>
            <input name="username" username={this.state.username} onChange={this.cambio}></input>
            <button type="submit" onClick={this.enviar}>Submit</button>
            </div>
    }
}

export default Form;