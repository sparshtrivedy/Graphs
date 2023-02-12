import { Dialog, DialogTitle, DialogContent, DialogContentText, DialogActions, Button } from "@mui/material";

function ModalDialogue(props: any) {
    return (
        <Dialog
            open={props.open}
            onClose={props.handleClose}
            aria-labelledby="alert-dialog-title"
            aria-describedby="alert-dialog-description"
        >
            <DialogTitle id="alert-dialog-title" sx={{backgroundColor: '#2e2c21', color: 'white'}}>
                {"Welcome!"}
            </DialogTitle>
            <DialogContent sx={{backgroundColor: '#3e3c2f'}}>
                <DialogContentText id="alert-dialog-description" sx={{paddingTop: 2}}>
                    {"Select lumber data type from the type dropdown to see the data for the same. To see the data for specific dates, select the dates from the date selector and click apply. Be sure to select both, from and to dates before clicking apply."}
                </DialogContentText>
            </DialogContent>
            <DialogActions sx={{backgroundColor: '#3e3c2f'}}>
                <Button color='warning' onClick={props.handleClose}>Close</Button>
            </DialogActions>
        </Dialog>
    );
}

export default ModalDialogue;