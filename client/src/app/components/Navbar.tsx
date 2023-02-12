import { AppBar, Toolbar, Typography } from "@mui/material";

function Navbar() {
    return (
        <AppBar position="static" sx={{backgroundColor: '#2e2c21', height: 60, alignItems: 'center', justifyContent: 'center'}}>
            <Toolbar variant="dense">
            <Typography variant="h4" color="inherit" component="div">
                Graphs
            </Typography>
            </Toolbar>
        </AppBar>
    );
}

export default Navbar;