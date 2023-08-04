import { CheckCircleOutlined } from '@ant-design/icons'
import { Breadcrumb, Button, Input, Popconfirm, Select, Table } from 'antd'
import { useState } from 'react';


function DangKiComponent(){
    const [dataSource, setDataSource] = useState([
        {
            key:'1',
            ten:'Nguyễn Văn A',
            ngayguidon:'5-5-2023',    
            daotrang:'Đạo trạng 1',
            trangthaidon:0
        },
        {
            key:'2',
            ten:'Nguyễn Văn An',
            ngayguidon:'5-6-2023',    
            daotrang:'Đạo trạng 2',
            trangthaidon:0
        },
        {
            key:'3',
            ten:'Nguyễn Văn B',
            ngayguidon:'6-6-2023',    
            daotrang:'Đạo trạng 1',
            trangthaidon:0
        },
        {
            key:'4',
            ten:'Nguyễn Văn Bình',
            ngayguidon:'8-6-2023',    
            daotrang:'Đạo trạng 1',
            trangthaidon:0
        },
        {
            key:'5',
            ten:'Nguyễn Văn Bình',
            ngayguidon:'8-6-2023',    
            daotrang:'Đạo trạng 2',
            trangthaidon:1
        },
    ])
    const columns = [
        {
          title: 'Phật tử',
          dataIndex:[
            'ten'
          ],
          key: 'ten',
          
        },
        {
          title: 'Ngày gửi đơn',
          dataIndex: 'ngayguidon',
          key: 'ngayguidon',
        },
        {
            title: 'Đạo tràng',
            dataIndex: 'daotrang',
            key: 'daotrang',
        },
        {
          title: 'Trạng thái đơn',
          dataIndex: 'trangthaidon',
          key: 'trangthaidon',
        },
        {
            key: 'action',
            render: (_, record) => record.trangthaidon ===0 ? (
                <Popconfirm title="Duyệt đơn này?" >
                  <a>Duyệt</a>
                </Popconfirm>
              ) : null,
          },
      ];
    return <div className='phattu'>
        <div>
            <Breadcrumb style={{ margin: '16px 0 0 0' }}>
                <Breadcrumb.Item>Home</Breadcrumb.Item>
                <Breadcrumb.Item>Đơn đăng kí</Breadcrumb.Item>
            </Breadcrumb>
            <div className='gsht'>Đơn đăng kí</div>
        </div>
        <div className='table'>
            <div style={{marginTop:'8px'}}>
            <Select
                    value={'Hiển thị 1-5 of 6'}
                    style={{
                        width: 150,
                        marginBottom:15
                    }}
                    options={[
                        {
                        value: '1den5',
                        label: 'Hiển thị 1-5 of 6',
                        },  
                        {
                        value: '6den10',
                        label: 'Hiển thị 6-10 of 6',
                        },
                        {
                        value: '11den15',
                        label: 'Hiển thị 11-15 of 6',
                        },      
                    ]}
                    />
            </div>
            <div className='bang'>
                <Table columns={columns} pagination={{
                position: ['none', 'none'],
              }} bordered={true} dataSource={dataSource} />
            </div>         
        </div>
    </div>
}
export default DangKiComponent