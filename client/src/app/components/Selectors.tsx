import { Box, Grid, IconButton, FormControl, InputLabel, Select, MenuItem, TextField, Button } from "@mui/material";
import { LocalizationProvider, DatePicker } from "@mui/x-date-pickers";
import { AdapterDayjs } from "@mui/x-date-pickers/AdapterDayjs";
import InfoOutlinedIcon from '@mui/icons-material/InfoOutlined';

function Selectors(props:any) {
    return (
        <Box sx={{ my: 3, mx: 2 }}>
            <Grid container alignItems="center" justifyContent={"center"}>
            <Grid item>
                <IconButton size="large" onClick={props.handleClickOpen}>
                <InfoOutlinedIcon color="warning" fontSize="large" sx={{marginRight: 2}} />
                </IconButton>
            </Grid>
            <Grid item>
                <FormControl sx={{marginBottom: 2, width: 100, marginTop: 2, marginRight: 2}}>
                <InputLabel id="graph-type" color="warning">Type</InputLabel>
                <Select
                    color="warning"
                    labelId="graph-type"
                    id="graph-type-select"
                    value={props.type}
                    label="Type"
                    onChange={props.handleChange}
                >
                    <MenuItem value={10}>Open</MenuItem>
                    <MenuItem value={20}>Close</MenuItem>
                    <MenuItem value={30}>Adjacent Close</MenuItem>
                    <MenuItem value={40}>High</MenuItem>
                    <MenuItem value={50}>Low</MenuItem>
                    <MenuItem value={60}>Volume</MenuItem>
                </Select>
                </FormControl>
            </Grid>
            <Grid item>
                <LocalizationProvider dateAdapter={AdapterDayjs}>
                <DatePicker
                    label="From date"
                    value={props.from}
                    onChange={(newValue) => {
                        props.setFrom(newValue);
                    }}
                    renderInput={(params) => <TextField color="warning" sx={{width: 150, marginRight: 2}} {...params} />}
                />
                </LocalizationProvider>
            </Grid>
            <Grid item>
                <LocalizationProvider dateAdapter={AdapterDayjs}>
                <DatePicker
                    label="To date"
                    value={props.to}
                    onChange={(newValue) => {
                        props.setTo(newValue);
                    }}
                    renderInput={(params) => <TextField color="warning" sx={{width: 150, marginRight: 2}} {...params} />}
                />
                </LocalizationProvider>
            </Grid>
            <Grid item>
                <Button variant="contained" size="large" color="warning" onClick={props.onClick} sx={{height: 55, width: 100}}>Apply</Button>
            </Grid>
            </Grid>
        </Box>
    );
}

export default Selectors;